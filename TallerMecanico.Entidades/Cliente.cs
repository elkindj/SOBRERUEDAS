using System;

namespace TallerMecanico.Entidades
{
    public class Cliente
    {
        public int _id;
        public int _idConductor;
        public string _cliNombres;
        public string _cliApellidos;
        public string _cliLicenciaTransito;
        public string _cliCorreo;
        public string _cliCelular;
        public string _cliDireccion;
        public string _cliUsuario;
        public DateTime _cliFechaReg;
        public string _cliUsuarioEdita;
        public DateTime _cliFechaEdita;

        public int Id
        {
            get { return _id; }
            set {_id = value; }
        }
        public int IdConductor
        {
            get { return _id; }
            set { _id = value; }
        }
        public string CliNombres
        {
            get { return _cliNombres; }
            set { _cliNombres = value; }
        }
        public string CliApellidos
        {
            get { return _cliApellidos; }
            set { _cliApellidos = value; }
        }
        public string CliLicenciaTransito
        {
            get { return _cliLicenciaTransito; }
            set { _cliLicenciaTransito = value; }
        }
        public string CliCorreo
        {
            get { return _cliCorreo; }
            set { _cliCorreo = value; }
        }
        public string CliCelular
        {
            get { return _cliCelular; }
            set { _cliCelular = value; }
        }
        public string CliDireccion
        {
            get { return _cliDireccion; }
            set { _cliDireccion = value; }
        }
        public string CliUsuario
        {
            get { return _cliUsuario; }
            set { _cliUsuario = value; }
        }
        public DateTime CliFechaReg
        {
            get { return _cliFechaReg; }
            set { _cliFechaReg = value; }
        }
        public string CliUsuarioEdita
        {
            get { return _cliUsuarioEdita; }
            set { _cliUsuarioEdita = value; }
        }
        public DateTime CliFechaEdita
        {
            get { return _cliFechaEdita; }
            set { _cliFechaEdita = value; }
        }
        public Cliente(
            int Id,
            int IdConductor,
            string CliNombres,
            string CliApellidos,
            string CliLicenciaTransito,
            string CliCorreo,
            string CliCelular,
            string CliDireccion,
            string CliUsuario,
            DateTime CliFechaReg,
            string CliUsuarioEdita,
            DateTime CliFechaEdita)
        {
            this._id = Id;
            this._idConductor = IdConductor;
            this._cliNombres = CliNombres;
            this._cliApellidos = CliApellidos;
            this._cliLicenciaTransito = CliLicenciaTransito;
            this._cliCorreo = CliCorreo;
            this._cliCelular = CliCelular;
            this._cliDireccion = CliDireccion;
            this._cliUsuario = CliUsuario;
            this._cliFechaReg = CliFechaReg;
            this._cliUsuarioEdita = CliUsuarioEdita;
            this._cliFechaEdita = CliFechaEdita;
        }

            public Cliente() : this(0, 0, "", "", "", "", "", "","", DateTime.Now, "", DateTime.Now)
            {
            }
        }
   }

