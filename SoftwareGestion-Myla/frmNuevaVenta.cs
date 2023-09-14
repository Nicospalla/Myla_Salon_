using Accesorios;
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
        ClientesNegocio ClientesNegocio = new();
        List<Especialista> listaEsp = new List<Especialista>();
        List<HistoVentas> listaVentaActual = new();
        Helpers help = new();
        CajaNegocio cajaNegocio = new();
        Decimal sumatoria;
        public int indexCboCat { get; set; }
        public frmNuevaVenta(frmPrincipal frmPrincipal, Clientes? cliente = null, HistoVentas? ventaImportada = null)
        {
            InitializeComponent();
            this.FrmPrincipal = frmPrincipal;
            if (cliente != null)
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
            if (cliente != null)
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
                cambiaCBOS();
                //int idEsp = aux.IdEspecialista;
                //cboEspecialista.SelectedValue = idEsp;
            }
            cboMetodo.Items.Add("Efectivo");
            cboMetodo.Items.Add("Tarjeta");
            cboMetodo.SelectedIndex = 0;

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
                txtCliente.Text = string.Empty;
                txtID.Text = string.Empty;
                txtCodigoTinte.Text = string.Empty;
                txtPorcentaje.Text = string.Empty;
                txtPrecio.Text = string.Empty;
                txtPrecioTotal.Text = string.Empty;
                txtServAdc.Text = string.Empty;
                listaVentaActual.Clear();
                actualizaLista();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

            bool status = true;
            status = cboCategoria.SelectedIndex != -1 ? status : false;
            lblErrorCat.Text = cboCategoria.SelectedIndex == -1 ? "Debe seleccionar una Categoría" : "";
            status = cboEspecialista.SelectedIndex != -1 ? status : false;
            lblErrorEspe.Text = cboEspecialista.SelectedIndex == -1 ? "Debe seleccionar un Especialista" : "";
            status = cboSubCat.SelectedIndex != -1 ? status : false;
            lblErrorSub.Text = cboSubCat.SelectedIndex == -1 ? "Debe seleccionar una SubCategoría" : "";
            status = !string.IsNullOrEmpty(txtPrecio.Text) && help.soloNum(txtPrecio.Text) ? status : false;
            lblErrorPrecio.Text = string.IsNullOrEmpty(txtPrecio.Text) || !help.soloNum(txtPrecio.Text) ? "Debe ingresar un precio válido al servicio" : "";
            if (!string.IsNullOrEmpty(txtPorcentaje.Text))
            {
                status = int.Parse(txtPorcentaje.Text) < 100 ? status : false;
                lblErrorPorcen.Text = int.Parse(txtPorcentaje.Text) >= 100 ? "El porcentaje debe ser menor a 100" : "";

            }
            status = !string.IsNullOrEmpty(txtCliente.Text) ? status : false;
            lblErrorID.Text = string.IsNullOrEmpty(txtCliente.Text) ? "Debe seleccionar un cliente" : "";
            if (status == false)
            {
                MessageBox.Show("Por favor revise los datos.", "Faltan datos", MessageBoxButtons.OK);
            }
            else
            {
                DialogResult result = MessageBox.Show("Está seguro de agregar éste servicio?", "Agregar servicio", MessageBoxButtons.OKCancel);
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
                    venta.IdCat.Descripcion = cat.Descripcion;

                    venta.Cliente = new Clientes();
                    venta.Cliente.Nombre = cliente.Nombre;
                    venta.IdCliente = cliente.Id;

                    venta.Especialista = new Especialista();
                    //Especialista esp = (Especialista)cboEspecialista.SelectedValue;
                    venta.Especialista.IdEspecialista = ((Especialista)cboEspecialista.SelectedValue).IdEspecialista;
                    venta.Especialista.Nombre = ((Especialista)cboEspecialista.SelectedValue).Nombre;
                    //venta.Especialista.IdEspecialista = (int)cboEspecialista.SelectedValue;

                    venta.CodigoTinte = txtCodigoTinte.Text;
                    venta.Fecha = DateTime.Today;

                    venta.IdSub = new SubCategoria();
                    //SubCategoria sub = (SubCategoria)cboSubCat.SelectedValue;
                    venta.IdSub.IdSub = ((SubCategoria)cboSubCat.SelectedValue).IdSub;
                    venta.IdSub.Descripcion = ((SubCategoria)cboSubCat.SelectedValue).Descripcion;

                    venta.ServicioAdicional = txtServAdc.Text;


                    if (!string.IsNullOrEmpty(txtPorcentaje.Text) && int.Parse(txtPorcentaje.Text) < 100 && help.soloNum(txtPorcentaje.Text) && help.soloNum(txtPrecio.Text))
                    {
                        Decimal auxPrecio = int.Parse(txtPrecio.Text) - ((int.Parse(txtPrecio.Text) * int.Parse(txtPorcentaje.Text)) / 100);
                        venta.Precio = txtPrecio.Text != "" ? Math.Truncate(auxPrecio * 100) / 100 : 0;
                    }
                    else if (string.IsNullOrEmpty(txtPorcentaje.Text) && help.soloNum(txtPorcentaje.Text) && help.soloNum(txtPrecio.Text))
                    {
                        venta.Precio = txtPrecio.Text != "" ? Math.Truncate(Decimal.Parse(txtPrecio.Text) * 100) / 100 : 0;
                    }
                    sumatoria += venta.Precio;
                    txtPrecioTotal.Text = sumatoria.ToString();

                    listaVentaActual.Add(venta);
                    actualizaLista();

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
            FrmPrincipal.muestraHistorial(cliente);
        }

        private void cboEspecialista_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cambiaCBOS();

        }

        private void cambiaCBOS()
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

        private void btnAgregarServicio_Click(object sender, EventArgs e)
        {
            bool status = false;
            if (cboMetodo.SelectedIndex > -1)
            {
                status = true;
                lblErrorMetodo.Text = string.Empty;
            }
            else
            {
                lblErrorMetodo.Text = "Debe seleccionar un Método de pago";
            }

            if (status == false)
                return;
            DialogResult result = MessageBox.Show("Confirma la venta?", "Guardar venta", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK && listaVentaActual.Count > 0)
            {
                for (int i = 0; i < listaVentaActual.Count; i++)
                {
                    ventasNegocio.accionSobreVentas(listaVentaActual[i]);
                    Caja caja = new();
                    if (cboMetodo.SelectedItem.ToString() == "Efectivo")
                    {
                        caja.PagoEfectivo = int.Parse(txtPrecioTotal.Text);
                    }
                    else if (cboMetodo.SelectedItem.ToString() == "Tarjeta")
                    {
                        caja.PagoTarjeta = int.Parse(txtPrecioTotal.Text);
                    }
                    caja.Fecha = DateTime.Today;
                    string Metodo = (string)cboMetodo.SelectedItem;
                    caja.Cliente = new Clientes();
                    caja.Cliente.Id = cliente.Id;
                    caja.Especialista = new Especialista();
                    caja.Especialista.IdEspecialista = listaVentaActual[i].Especialista.IdEspecialista;
                    cajaNegocio.nuevaVenta(caja, Metodo);
                }

                FrmPrincipal.muestraHistorial(cliente);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtID.Text) && help.soloNum(txtID.Text))
            {
                List<Clientes> lista0 = ClientesNegocio.listar(int.Parse(txtID.Text));
                if (lista0.Count > 0)
                {
                    Clientes aux = lista0[0];
                    txtCliente.Text = aux.Nombre.ToString();
                    cliente = aux;
                    lblErrorID.Text = "";
                }
                else
                {
                    lblErrorID.Text = "El cliente parece no existir, chequee el Nro de Cliente.";
                }
            }
        }

        private void btnBorraServ_Click(object sender, EventArgs e)
        {
            dgvVentas.Focus();
            if (dgvVentas.CurrentRow != null)
            {
                Decimal sumaTotal = int.Parse(txtPrecioTotal.Text) - ((HistoVentas)dgvVentas.CurrentRow.DataBoundItem).Precio;
                txtPrecioTotal.Text = sumaTotal.ToString();
                listaVentaActual.Remove((HistoVentas)dgvVentas.CurrentRow.DataBoundItem);
                actualizaLista();
            }
        }
        public void actualizaLista()
        {
            cboEspecialista.SelectedIndex = -1;
            cboCategoria.SelectedIndex = -1;
            txtPrecio.Text = string.Empty;
            txtServAdc.Text = string.Empty;
            txtCodigoTinte.Text = string.Empty;
            txtPorcentaje.Text = string.Empty;
            dgvVentas.DataSource = null;
            dgvVentas.DataSource = listaVentaActual;
            dgvVentas.Columns["IdVenta"].Visible = false;
            dgvVentas.Columns["IdCliente"].Visible = false;
            dgvVentas.Refresh();
        }
    }
}


