using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerMecanico.Entidades
{
    public class FichaTecnica
    {
        //public int _idConsecutivo;
        public string _ftTarjetaOperacion;
        public string _ftEstado;
        public int _ftNumRtmyG;
        public int _ftNumeroPolizaSOAT;
        public int _ftNumeroPolizaRCE;
        public int _ftLicenciaTransito;
        public string _ftEmisionGasesGasolina;
        public string _ftEmisionesGasesDiesel;
        public string _ftLucesPrincipal;
        public string _ftPruebaFreno;
        public string _ftAlineacion;
        public string _ftAdherencia;
        public string _ftEmisionRuido;
        public string _ftGrupoFreno;
        public string _ftGrupoSuspension;
        public string _ftGrupoDireccion;
        public string _ftRinLLanta;
        public string _ftGrupoLuces;
        public string _ftGrupoVidrio;
        public string _ftGrupoTransmision;
        public string _ftGrupoMotor;
        public string _ftRevisionInterior;
        public string _ftRevisionExterior;
        public string _ftApto;
        public string _empresa;
        public int _idConductor;

        public string FtTarjetaOperacion
        {
            get { return _ftTarjetaOperacion; }
            set { _ftTarjetaOperacion = value; }
        }
        public string FtEstado
        {
            get { return _ftEstado; }
            set { _ftEstado = value; }
        }
        public int FtNumRtmyG
        {
            get { return _ftNumRtmyG; }
            set { _ftNumRtmyG = value; }
        }
        public int FtNumeroPolizaSOAT
        {
            get { return _ftNumeroPolizaSOAT; }
            set { _ftNumeroPolizaSOAT = value; }
        }
        public int FtNumeroPolizaRCE
        {
            get { return _ftNumeroPolizaRCE; }
            set { _ftNumeroPolizaRCE = value; }
        }
        public int FtLicenciaTransito
        {
            get { return _ftLicenciaTransito; }
            set { _ftLicenciaTransito = value; }
        }
        public string FtEmisionGasesGasolina
        {
            get { return _ftEmisionGasesGasolina; }
            set { _ftEmisionGasesGasolina = value; }
        }
        public string FtEmisionesGasesDiesel
        {
            get { return _ftEmisionesGasesDiesel; }
            set { _ftEmisionesGasesDiesel = value; }
        }
        public string FtLucesPrincipal
        {
            get { return _ftLucesPrincipal; }
            set { _ftLucesPrincipal = value; }
        }
        public string FtPruebaFreno
        {
            get { return _ftPruebaFreno; }
            set { _ftPruebaFreno = value; }
        }
        public string FtAlineacion
        {
            get { return _ftAlineacion; }
            set { _ftAlineacion = value; }
        }
        public string FtAdherencia
        {
            get { return _ftAdherencia; }
            set { _ftAdherencia = value; }
        }
        public string FtEmisionRuido
        {
            get { return _ftEmisionRuido; }
            set { _ftEmisionRuido = value; }
        }
        public string FtGrupoFreno
        {
            get { return _ftGrupoFreno; }
            set { _ftGrupoFreno = value; }
        }
        public string FtGrupoSuspension
        {
            get { return _ftGrupoSuspension; }
            set { _ftGrupoSuspension = value; }
        }
        public string FtGrupoDireccion
        {
            get { return _ftGrupoDireccion; }
            set { _ftGrupoDireccion = value; }
        }
        public string FtRinLLanta
        {
            get { return _ftRinLLanta; }
            set { _ftRinLLanta = value; }
        }
        public string FtGrupoLuces
        {
            get { return _ftGrupoLuces; }
            set { _ftGrupoLuces = value; }
        }
        public string FtGrupoVidrio
        {
            get { return _ftGrupoVidrio; }
            set { _ftGrupoVidrio = value; }
        }
        public string FtGrupoTransmision
        {
            get { return _ftGrupoTransmision; }
            set { _ftGrupoTransmision = value; }
        }
        public string FtGrupoMotor
        {
            get { return _ftGrupoMotor; }
            set { _ftGrupoMotor = value; }
        }
        public string FtRevisionInterior
        {
            get { return _ftRevisionInterior; }
            set { _ftRevisionInterior = value; }
        }
        public string FtRevisionExterior
        {
            get { return _ftRevisionExterior; }
            set { _ftRevisionExterior = value; }
        }
        public string FtApto
        {
            get { return _ftApto; }
            set { _ftApto = value; }
        }
        public int IdConductor
        {
            get { return _idConductor; }
            set { _idConductor = value; }
        }
        public string Empresa
        {
            get { return _empresa; }
            set { _empresa = value; }
        }
        public FichaTecnica(
         string FtTarjetaOperacion,
         string FtEstado,
         int FtNumRtmyG,
         int FtNumeroPolizaSOAT,
         int FtNumeroPolizaRCE,
         int FtLicenciaTransito,
         string FtEmisionGasesGasolina,
         string FtEmisionesGasesDiesel,
         string FtLucesPrincipal,
         string FtPruebaFreno,
         string FtAlineacion,
         string FtAdherencia,
         string FtEmisionRuido,
         string FtGrupoFreno,
         string FtGrupoSuspension,
         string FtGrupoDireccion,
         string FtRinLLanta,
         string FtGrupoLuces,
         string FtGrupoVidrio,
         string FtGrupoTransmision,
         string FtGrupoMotor,
         string FtRevisionInterior,
         string FtRevisionExterior,
         string FtApto,
         string Empresa,
         int IdConductor
         )
        {
            this._ftTarjetaOperacion = FtTarjetaOperacion;
            this._ftEstado = FtEstado;
            this._ftNumRtmyG = FtNumRtmyG;
            this._ftNumeroPolizaSOAT = FtNumeroPolizaSOAT;
            this._ftNumeroPolizaRCE = FtNumeroPolizaRCE;
            this._ftLicenciaTransito = FtLicenciaTransito;
            this._ftEmisionGasesGasolina = FtEmisionGasesGasolina;
            this._ftEmisionesGasesDiesel = FtEmisionesGasesDiesel;
            this._ftLucesPrincipal = FtLucesPrincipal;
            this._ftPruebaFreno = FtPruebaFreno;
            this._ftAlineacion = FtAlineacion;
            this._ftAdherencia = FtAdherencia;
            this._ftEmisionRuido = FtEmisionRuido;
            this._ftGrupoFreno = FtGrupoFreno;
            this._ftGrupoSuspension = FtGrupoSuspension;
            this._ftGrupoDireccion = FtGrupoDireccion;
            this._ftRinLLanta = FtRinLLanta;
            this._ftGrupoLuces = FtGrupoLuces;
            this._ftGrupoVidrio = FtGrupoVidrio;
            this._ftGrupoTransmision = FtGrupoTransmision;
            this._ftGrupoMotor = FtGrupoMotor;
            this._ftRevisionInterior = FtRevisionInterior;
            this._ftRevisionExterior = FtRevisionExterior;
            this._ftApto = FtApto;
            this._empresa = Empresa;
            this._idConductor = IdConductor;
        }

        public FichaTecnica() : this("", "", 0, 0, 0, 0, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", 0) { }
        Cliente categoria = new Cliente();
        Vehiculo vehiculo = new Vehiculo();
    }
}
