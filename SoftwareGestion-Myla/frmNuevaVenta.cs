using Dominio;
using Negocio;

namespace SoftwareGestion_Myla
{
    public partial class frmNuevaVenta : Form
    {
        private frmPrincipal FrmPrincipal;
        private Clientes cliente;
        CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
        SubCategoriaNegocio SubCategoriaNegocio = new SubCategoriaNegocio();
        EspecialistaNegocio EspecialistaNegocio = new EspecialistaNegocio();
        Especialistas_Categorias_Negocio Especialistas_Categorias_Negocio = new Especialistas_Categorias_Negocio();
        HistoVentasNegocio ventasNegocio = new HistoVentasNegocio();
        HistoVentas? ventaImportada;
        List<Especialista> listaEsp = new List<Especialista>();
        public int indexCboCat { get; set; }
        public frmNuevaVenta(Clientes cliente, frmPrincipal frmPrincipal, HistoVentas? ventaImportada = null)
        {
            InitializeComponent();
            this.FrmPrincipal = frmPrincipal;
            this.cliente = cliente;
            if (ventaImportada != null)
            {
                this.ventaImportada = ventaImportada;
            }
            indexCboCat = -1;
        }

        private void frmNuevaVenta_Load(object sender, EventArgs e)
        {
            txtCliente.ReadOnly = true;
            txtCliente.Text = cliente.Nombre;
            listaEsp = EspecialistaNegocio.listaEspecialista();
            cboEspecialista.DataSource = listaEsp;
            //cboEspecialista.DisplayMember = "Descripcion";
            //cboEspecialista.ValueMember = "IdEspecialista";
            cboEspecialista.SelectedIndex = -1;
            if (ventaImportada != null)
            {

                cboCategoria.SelectedValue = ventaImportada.IdCat;
                txtPrecio.Text = ventaImportada.Precio.ToString();
                txtServAdc.Text = ventaImportada.ServicioAdicional.ToString();
                txtCodigoTinte.Text = ventaImportada.CodigoTinte;

                int index = -1;
                for (int i = 0; i < listaEsp.Count; i++)
                {
                    if (listaEsp[i].Nombre == ventaImportada.Especialista.Nombre)
                    {
                        index = i;
                        break;
                    }
                }
                cboEspecialista.SelectedIndex = index;




                //int idEsp = aux.IdEspecialista;
                //cboEspecialista.SelectedValue = idEsp;
            }

        }

        private void cboCategoria_SelectedValueChanged(object sender, EventArgs e)
        {
            //    //Aca carga la seccion de sub categorias, que depende del ESPECIALISTA (A su vez, tiene la
            //    //  - dependencia con las CAT)
            if (cboCategoria.SelectedIndex != -1)
            {
                Categorias auxCat = (Categorias)cboCategoria.SelectedValue;
                Especialista aux = (Especialista)cboEspecialista.SelectedValue;
                List<SubCategoria> subCategorias = SubCategoriaNegocio.listarSubCat(aux.IdEspecialista, auxCat.idCat, true);
                cboSubCat.DataSource = subCategorias;
                cboSubCat.DisplayMember = "Descripcion";
                //cboSubCat.ValueMember = "IdSub";

                int indexSub = -1;
                if (ventaImportada != null && cboCategoria.SelectedIndex == indexCboCat && ventaImportada.IdSub != null)
                {
                    for (int i = 0; i < subCategorias.Count; i++)
                    {
                        if (subCategorias[i].IdSub == ventaImportada.IdSub.idCategoria)
                        {
                            indexSub = i;
                            break;
                        }
                    }
                    //cboSubCat.SelectedIndex = indexSub;
                }
                cboSubCat.SelectedIndex = indexSub;
            }
            else
            {

                cboSubCat.DataSource = null;
                cboSubCat.SelectedIndex = -1;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Está seguro que desea borrar los datos?", "Volver a grilla principal", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                FrmPrincipal.verGrilla();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool status = true;
            status = cboCategoria.SelectedIndex != -1 ? status : false;
            lblErrorCat.Text = cboCategoria.SelectedIndex == -1 ? "Debe seleccionar una Categoría" : "";
            status = cboEspecialista.SelectedIndex != -1 ? status : false;
            lblErrorEspe.Text = cboEspecialista.SelectedIndex == -1 ? "Debe seleccionar un Especialista" : "";
            if (status == false)
            {
                MessageBox.Show("Por favor revise los datos.", "Faltan datos", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult result = MessageBox.Show("Esta segura de guardar ésta nueva venta?", "Nueva venta", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    HistoVentas venta = new HistoVentas();
                    if (ventaImportada != null)
                    {
                        venta = ventaImportada;
                    }

                    venta.IdCat = new Categorias();
                    Categorias cat = (Categorias)cboCategoria.SelectedValue;
                    venta.IdCat.idCat = cat.idCat;

                    venta.IdCliente = cliente.Id;

                    venta.Especialista = new Especialista();
                    //Especialista esp = (Especialista)cboEspecialista.SelectedValue;
                    venta.Especialista.IdEspecialista = ((Especialista)cboEspecialista.SelectedValue).IdEspecialista;
                    //venta.Especialista.IdEspecialista = (int)cboEspecialista.SelectedValue;

                    venta.CodigoTinte = txtCodigoTinte.Text;
                    venta.Precio = txtPrecio.Text != "" ? Math.Truncate(Decimal.Parse(txtPrecio.Text) * 100) / 100 : 0;
                    venta.Fecha = DateTime.Today;

                    venta.IdSub = new SubCategoria();
                    //SubCategoria sub = (SubCategoria)cboSubCat.SelectedValue;
                    venta.IdSub.IdSub = ((SubCategoria)cboSubCat.SelectedValue).IdSub;

                    venta.ServicioAdicional = txtServAdc.Text;

                    ventasNegocio.accionSobreVentas(venta);
                    FrmPrincipal.muestraHistorial(cliente);
                }
                else
                    return;

            }
        }

        private void cboEspecialista_SelectedIndexChanged(object sender, EventArgs e)
        {

            //if (cboEspecialista.SelectedIndex != -1)
            //{
            //    Especialista aux = (Especialista)cboEspecialista.SelectedValue;
            //    List<Categorias> listaCat = categoriaNegocio.listarCat(aux.IdEspecialista, true);
            //    cboCategoria.DataSource = listaCat;
            //    cboCategoria.DisplayMember = "Descripcion";

            //    if (ventaImportada != null)
            //    {
            //        indexCboCat = -1;
            //        for (int i = 0; i < listaCat.Count; i++)
            //        {
            //            if (listaCat[i].idCat == ventaImportada.IdCat.idCat)
            //            {
            //                indexCboCat = i;
            //                break;
            //            }
            //        }

            //        cboCategoria.SelectedIndex = indexCboCat;
            //    }
            //    else
            //    {
            //        cboCategoria.SelectedIndex = -1;

            //    }

            //}
            //else
            //{
            //    cboCategoria.DataSource = null;
            //    cboCategoria.SelectedIndex = -1;
            //}
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            FrmPrincipal.verGrilla();
        }

        private void cboEspecialista_SelectionChangeCommitted(object sender, EventArgs e)
        {

            if (cboEspecialista.SelectedIndex != -1)
            {
                Especialista aux = (Especialista)cboEspecialista.SelectedValue;
                List<Categorias> listaCat = categoriaNegocio.listarCat(aux.IdEspecialista, true);
                cboCategoria.DataSource = listaCat;
                cboCategoria.DisplayMember = "Descripcion";

                if (ventaImportada != null)
                {
                    indexCboCat = -1;
                    for (int i = 0; i < listaCat.Count; i++)
                    {
                        if (listaCat[i].idCat == ventaImportada.IdCat.idCat)
                        {
                            indexCboCat = i;
                            break;
                        }
                    }

                    cboCategoria.SelectedIndex = indexCboCat;
                }
                else
                {
                    cboCategoria.SelectedIndex = -1;

                }

            }
            else
            {
                cboCategoria.DataSource = null;
                cboCategoria.SelectedIndex = -1;
            }
        }
    }
}


