using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDCS.ModelTransformation
{

    // NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
    public partial class updateRequest
    {

        private updateRequestOrganisation[] organisationListField;

        private updateRequestLangStat[] langStatListField;

        private updateRequestNatOffreHulpwijz[] natOffreHulpwijzListField;

        private updateRequestOffrLingTaal[] offrLingTaalListField;

        private updateRequestStatutStatuut[] statutStatuutListField;

        private updateRequestZoneActionWerkgebied[] zoneActionWerkgebiedListField;

        private updateRequestPouvoirAgreantErkenning[] pouvoirAgreantErkenningListField;

        private updateRequestAgrementErken[] agrementErkenListField;

        private string schemaLocationField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("organisation", IsNullable = false)]
        public updateRequestOrganisation[] organisationList
        {
            get
            {
                return this.organisationListField;
            }
            set
            {
                this.organisationListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("LangStat", IsNullable = false)]
        public updateRequestLangStat[] LangStatList
        {
            get
            {
                return this.langStatListField;
            }
            set
            {
                this.langStatListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("natOffreHulpwijz", IsNullable = false)]
        public updateRequestNatOffreHulpwijz[] natOffreHulpwijzList
        {
            get
            {
                return this.natOffreHulpwijzListField;
            }
            set
            {
                this.natOffreHulpwijzListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("offrLingTaal", IsNullable = false)]
        public updateRequestOffrLingTaal[] offrLingTaalList
        {
            get
            {
                return this.offrLingTaalListField;
            }
            set
            {
                this.offrLingTaalListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("StatutStatuut", IsNullable = false)]
        public updateRequestStatutStatuut[] StatutStatuutList
        {
            get
            {
                return this.statutStatuutListField;
            }
            set
            {
                this.statutStatuutListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("zoneActionWerkgebied", IsNullable = false)]
        public updateRequestZoneActionWerkgebied[] zoneActionWerkgebiedList
        {
            get
            {
                return this.zoneActionWerkgebiedListField;
            }
            set
            {
                this.zoneActionWerkgebiedListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("pouvoirAgreantErkenning", IsNullable = false)]
        public updateRequestPouvoirAgreantErkenning[] pouvoirAgreantErkenningList
        {
            get
            {
                return this.pouvoirAgreantErkenningListField;
            }
            set
            {
                this.pouvoirAgreantErkenningListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("agrementErken", IsNullable = false)]
        public updateRequestAgrementErken[] agrementErkenList
        {
            get
            {
                return this.agrementErkenListField;
            }
            set
            {
                this.agrementErkenListField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string schemaLocation
        {
            get
            {
                return this.schemaLocationField;
            }
            set
            {
                this.schemaLocationField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class updateRequestOrganisation
    {

        private int idField;

        private int fICHEField;

        private string iNFORField;

        private string nMOFFNLField;

        private string nMOFFFRField;

        private string[] nMUSENLField;

        private string[] nMUSEFRField;

        private string[] nMSERVNLField;

        private string[] nMSERVFRField;

        private string[] tEL_NLField;

        private string[] tELField;

        private string[] fAXField;

        private string[] eMAIL_NLField;

        private string[] eMAILField;

        private string hTTP_NLField;

        private string hTTPField;

        private string[] hTTPNL2Field;

        private string[] hTTP2Field;

        private string[] uRLNLField;

        private string[] uRLFRField;

        private string aCTIVNLField;

        private string aCTIVFRField;

        private string pUBLIEKField;

        private string bENEFField;

        private string pERMANNLField;

        private string pERMANFRField;

        private string[] tIJDSCHRField;

        private string[] rEVUEField;

        private string oPMERKField;

        private string rEMARQUEField;

        private string pM_RPField;

        private string dOELField;

        private string bUTField;

        private string pUBLIBSField;

        private string pUBLIMBField;

        private string bRUSOFRField;

        private string bRUSONLField;

        private string[] eRKANDField;

        private string[] aGRAUTRField;

        private string[] oLDNAMNLField;

        private string[] oLDNAMFRField;

        private string cREEField;

        private string dEELField;

        private string aNTENNEField;

        private string mOTHERField;

        private string[] fAX_NLField;

        private string iNT_SOCField;

        private updateRequestOrganisationAddresseAdres addresseAdresField;

        private int statutstatuutField;

        private bool statutstatuutFieldSpecified;

        private string lANGSTATField;

        private string[] aCCESField;

        private string[] aANMELDField;

        private int[] offrLingTaalAnbField;

        private int[] natOffreHulpwijzField;

        private int[] agrementErkenField;

        private int[] zoneActionWerkgebiedField;

        private int[] cATEGField;

        /// <remarks/>
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        public int FICHE
        {
            get
            {
                return this.fICHEField;
            }
            set
            {
                this.fICHEField = value;
            }
        }

        /// <remarks/>
        public string INFOR
        {
            get
            {
                return this.iNFORField;
            }
            set
            {
                this.iNFORField = value;
            }
        }

        /// <remarks/>
        public string NMOFFNL
        {
            get
            {
                return this.nMOFFNLField;
            }
            set
            {
                this.nMOFFNLField = value;
            }
        }

        /// <remarks/>
        public string NMOFFFR
        {
            get
            {
                return this.nMOFFFRField;
            }
            set
            {
                this.nMOFFFRField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NMUSENL")]
        public string[] NMUSENL
        {
            get
            {
                return this.nMUSENLField;
            }
            set
            {
                this.nMUSENLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NMUSEFR")]
        public string[] NMUSEFR
        {
            get
            {
                return this.nMUSEFRField;
            }
            set
            {
                this.nMUSEFRField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NMSERVNL")]
        public string[] NMSERVNL
        {
            get
            {
                return this.nMSERVNLField;
            }
            set
            {
                this.nMSERVNLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NMSERVFR")]
        public string[] NMSERVFR
        {
            get
            {
                return this.nMSERVFRField;
            }
            set
            {
                this.nMSERVFRField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TEL_NL")]
        public string[] TEL_NL
        {
            get
            {
                return this.tEL_NLField;
            }
            set
            {
                this.tEL_NLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TEL")]
        public string[] TEL
        {
            get
            {
                return this.tELField;
            }
            set
            {
                this.tELField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FAX")]
        public string[] FAX
        {
            get
            {
                return this.fAXField;
            }
            set
            {
                this.fAXField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EMAIL_NL")]
        public string[] EMAIL_NL
        {
            get
            {
                return this.eMAIL_NLField;
            }
            set
            {
                this.eMAIL_NLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EMAIL")]
        public string[] EMAIL
        {
            get
            {
                return this.eMAILField;
            }
            set
            {
                this.eMAILField = value;
            }
        }

        /// <remarks/>
        public string HTTP_NL
        {
            get
            {
                return this.hTTP_NLField;
            }
            set
            {
                this.hTTP_NLField = value;
            }
        }

        /// <remarks/>
        public string HTTP
        {
            get
            {
                return this.hTTPField;
            }
            set
            {
                this.hTTPField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HTTPNL2")]
        public string[] HTTPNL2
        {
            get
            {
                return this.hTTPNL2Field;
            }
            set
            {
                this.hTTPNL2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HTTP2")]
        public string[] HTTP2
        {
            get
            {
                return this.hTTP2Field;
            }
            set
            {
                this.hTTP2Field = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("URLNL")]
        public string[] URLNL
        {
            get
            {
                return this.uRLNLField;
            }
            set
            {
                this.uRLNLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("URLFR")]
        public string[] URLFR
        {
            get
            {
                return this.uRLFRField;
            }
            set
            {
                this.uRLFRField = value;
            }
        }

        /// <remarks/>
        public string ACTIVNL
        {
            get
            {
                return this.aCTIVNLField;
            }
            set
            {
                this.aCTIVNLField = value;
            }
        }

        /// <remarks/>
        public string ACTIVFR
        {
            get
            {
                return this.aCTIVFRField;
            }
            set
            {
                this.aCTIVFRField = value;
            }
        }

        /// <remarks/>
        public string PUBLIEK
        {
            get
            {
                return this.pUBLIEKField;
            }
            set
            {
                this.pUBLIEKField = value;
            }
        }

        /// <remarks/>
        public string BENEF
        {
            get
            {
                return this.bENEFField;
            }
            set
            {
                this.bENEFField = value;
            }
        }

        /// <remarks/>
        public string PERMANNL
        {
            get
            {
                return this.pERMANNLField;
            }
            set
            {
                this.pERMANNLField = value;
            }
        }

        /// <remarks/>
        public string PERMANFR
        {
            get
            {
                return this.pERMANFRField;
            }
            set
            {
                this.pERMANFRField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TIJDSCHR")]
        public string[] TIJDSCHR
        {
            get
            {
                return this.tIJDSCHRField;
            }
            set
            {
                this.tIJDSCHRField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("REVUE")]
        public string[] REVUE
        {
            get
            {
                return this.rEVUEField;
            }
            set
            {
                this.rEVUEField = value;
            }
        }

        /// <remarks/>
        public string OPMERK
        {
            get
            {
                return this.oPMERKField;
            }
            set
            {
                this.oPMERKField = value;
            }
        }

        /// <remarks/>
        public string REMARQUE
        {
            get
            {
                return this.rEMARQUEField;
            }
            set
            {
                this.rEMARQUEField = value;
            }
        }

        /// <remarks/>
        public string PM_RP
        {
            get
            {
                return this.pM_RPField;
            }
            set
            {
                this.pM_RPField = value;
            }
        }

        /// <remarks/>
        public string DOEL
        {
            get
            {
                return this.dOELField;
            }
            set
            {
                this.dOELField = value;
            }
        }

        /// <remarks/>
        public string BUT
        {
            get
            {
                return this.bUTField;
            }
            set
            {
                this.bUTField = value;
            }
        }

        /// <remarks/>
        public string PUBLIBS
        {
            get
            {
                return this.pUBLIBSField;
            }
            set
            {
                this.pUBLIBSField = value;
            }
        }

        /// <remarks/>
        public string PUBLIMB
        {
            get
            {
                return this.pUBLIMBField;
            }
            set
            {
                this.pUBLIMBField = value;
            }
        }

        /// <remarks/>
        public string BRUSOFR
        {
            get
            {
                return this.bRUSOFRField;
            }
            set
            {
                this.bRUSOFRField = value;
            }
        }

        /// <remarks/>
        public string BRUSONL
        {
            get
            {
                return this.bRUSONLField;
            }
            set
            {
                this.bRUSONLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ERKAND")]
        public string[] ERKAND
        {
            get
            {
                return this.eRKANDField;
            }
            set
            {
                this.eRKANDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AGRAUTR")]
        public string[] AGRAUTR
        {
            get
            {
                return this.aGRAUTRField;
            }
            set
            {
                this.aGRAUTRField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OLDNAMNL")]
        public string[] OLDNAMNL
        {
            get
            {
                return this.oLDNAMNLField;
            }
            set
            {
                this.oLDNAMNLField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OLDNAMFR")]
        public string[] OLDNAMFR
        {
            get
            {
                return this.oLDNAMFRField;
            }
            set
            {
                this.oLDNAMFRField = value;
            }
        }

        /// <remarks/>
        public string CREE
        {
            get
            {
                return this.cREEField;
            }
            set
            {
                this.cREEField = value;
            }
        }

        /// <remarks/>
        public string DEEL
        {
            get
            {
                return this.dEELField;
            }
            set
            {
                this.dEELField = value;
            }
        }

        /// <remarks/>
        public string ANTENNE
        {
            get
            {
                return this.aNTENNEField;
            }
            set
            {
                this.aNTENNEField = value;
            }
        }

        /// <remarks/>
        public string MOTHER
        {
            get
            {
                return this.mOTHERField;
            }
            set
            {
                this.mOTHERField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FAX_NL")]
        public string[] FAX_NL
        {
            get
            {
                return this.fAX_NLField;
            }
            set
            {
                this.fAX_NLField = value;
            }
        }

        /// <remarks/>
        public string INT_SOC
        {
            get
            {
                return this.iNT_SOCField;
            }
            set
            {
                this.iNT_SOCField = value;
            }
        }

        /// <remarks/>
        public updateRequestOrganisationAddresseAdres addresseAdres
        {
            get
            {
                return this.addresseAdresField;
            }
            set
            {
                this.addresseAdresField = value;
            }
        }

        /// <remarks/>
        public int statutstatuut
        {
            get
            {
                return this.statutstatuutField;
            }
            set
            {
                this.statutstatuutField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool statutstatuutSpecified
        {
            get
            {
                return this.statutstatuutFieldSpecified;
            }
            set
            {
                this.statutstatuutFieldSpecified = value;
            }
        }

        /// <remarks/>
        public string LANGSTAT
        {
            get
            {
                return this.lANGSTATField;
            }
            set
            {
                this.lANGSTATField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ACCES")]
        public string[] ACCES
        {
            get
            {
                return this.aCCESField;
            }
            set
            {
                this.aCCESField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AANMELD")]
        public string[] AANMELD
        {
            get
            {
                return this.aANMELDField;
            }
            set
            {
                this.aANMELDField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("offrLingTaalAnb")]
        public int[] offrLingTaalAnb
        {
            get
            {
                return this.offrLingTaalAnbField;
            }
            set
            {
                this.offrLingTaalAnbField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("natOffreHulpwijz")]
        public int[] natOffreHulpwijz
        {
            get
            {
                return this.natOffreHulpwijzField;
            }
            set
            {
                this.natOffreHulpwijzField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("agrementErken")]
        public int[] agrementErken
        {
            get
            {
                return this.agrementErkenField;
            }
            set
            {
                this.agrementErkenField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("zoneActionWerkgebied")]
        public int[] zoneActionWerkgebied
        {
            get
            {
                return this.zoneActionWerkgebiedField;
            }
            set
            {
                this.zoneActionWerkgebiedField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("CATEG")]
        public int[] CATEG
        {
            get
            {
                return this.cATEGField;
            }
            set
            {
                this.cATEGField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class updateRequestOrganisationAddresseAdres
    {

        private string aDRESNLField;

        private string aDRESFRField;

        private string aDNUMField;

        private string bNUMField;

        private string pOSTNLField;

        private string pOSTFRField;

        private string zIPField;

        private string gEMEENTEField;

        private string cOMMUNEField;

        private string aDOPMField;

        private string aDREMField;

        private string wIJKField;

        private string qUARTIERField;

        private string sTATCODEField;

        private string sTATNMNLField;

        private string sTATNMFRField;

        private string xCOORDField;

        private string yCOORDField;

        private string wGS84LATField;

        private string wGS84LONField;

        private string wQ_CODEField;

        /// <remarks/>
        public string ADRESNL
        {
            get
            {
                return this.aDRESNLField;
            }
            set
            {
                this.aDRESNLField = value;
            }
        }

        /// <remarks/>
        public string ADRESFR
        {
            get
            {
                return this.aDRESFRField;
            }
            set
            {
                this.aDRESFRField = value;
            }
        }

        /// <remarks/>
        public string ADNUM
        {
            get
            {
                return this.aDNUMField;
            }
            set
            {
                this.aDNUMField = value;
            }
        }

        /// <remarks/>
        public string BNUM
        {
            get
            {
                return this.bNUMField;
            }
            set
            {
                this.bNUMField = value;
            }
        }

        /// <remarks/>
        public string POSTNL
        {
            get
            {
                return this.pOSTNLField;
            }
            set
            {
                this.pOSTNLField = value;
            }
        }

        /// <remarks/>
        public string POSTFR
        {
            get
            {
                return this.pOSTFRField;
            }
            set
            {
                this.pOSTFRField = value;
            }
        }

        /// <remarks/>
        public string ZIP
        {
            get
            {
                return this.zIPField;
            }
            set
            {
                this.zIPField = value;
            }
        }

        /// <remarks/>
        public string GEMEENTE
        {
            get
            {
                return this.gEMEENTEField;
            }
            set
            {
                this.gEMEENTEField = value;
            }
        }

        /// <remarks/>
        public string COMMUNE
        {
            get
            {
                return this.cOMMUNEField;
            }
            set
            {
                this.cOMMUNEField = value;
            }
        }

        /// <remarks/>
        public string ADOPM
        {
            get
            {
                return this.aDOPMField;
            }
            set
            {
                this.aDOPMField = value;
            }
        }

        /// <remarks/>
        public string ADREM
        {
            get
            {
                return this.aDREMField;
            }
            set
            {
                this.aDREMField = value;
            }
        }

        /// <remarks/>
        public string WIJK
        {
            get
            {
                return this.wIJKField;
            }
            set
            {
                this.wIJKField = value;
            }
        }

        /// <remarks/>
        public string QUARTIER
        {
            get
            {
                return this.qUARTIERField;
            }
            set
            {
                this.qUARTIERField = value;
            }
        }

        /// <remarks/>
        public string STATCODE
        {
            get
            {
                return this.sTATCODEField;
            }
            set
            {
                this.sTATCODEField = value;
            }
        }

        /// <remarks/>
        public string STATNMNL
        {
            get
            {
                return this.sTATNMNLField;
            }
            set
            {
                this.sTATNMNLField = value;
            }
        }

        /// <remarks/>
        public string STATNMFR
        {
            get
            {
                return this.sTATNMFRField;
            }
            set
            {
                this.sTATNMFRField = value;
            }
        }

        /// <remarks/>
        public string XCOORD
        {
            get
            {
                return this.xCOORDField;
            }
            set
            {
                this.xCOORDField = value;
            }
        }

        /// <remarks/>
        public string YCOORD
        {
            get
            {
                return this.yCOORDField;
            }
            set
            {
                this.yCOORDField = value;
            }
        }

        /// <remarks/>
        public string WGS84LAT
        {
            get
            {
                return this.wGS84LATField;
            }
            set
            {
                this.wGS84LATField = value;
            }
        }

        /// <remarks/>
        public string WGS84LON
        {
            get
            {
                return this.wGS84LONField;
            }
            set
            {
                this.wGS84LONField = value;
            }
        }

        /// <remarks/>
        public string WQ_CODE
        {
            get
            {
                return this.wQ_CODEField;
            }
            set
            {
                this.wQ_CODEField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class updateRequestLangStat
    {

        private int idField;

        private updateRequestLangStatValue[] valueField;

        /// <remarks/>
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("value")]
        public updateRequestLangStatValue[] value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class updateRequestLangStatValue
    {

        private string i18nField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string i18n
        {
            get
            {
                return this.i18nField;
            }
            set
            {
                this.i18nField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class updateRequestNatOffreHulpwijz
    {

        private int idField;

        private updateRequestNatOffreHulpwijzValue[] valueField;

        /// <remarks/>
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("value")]
        public updateRequestNatOffreHulpwijzValue[] value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class updateRequestNatOffreHulpwijzValue
    {

        private string i18nField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string i18n
        {
            get
            {
                return this.i18nField;
            }
            set
            {
                this.i18nField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class updateRequestOffrLingTaal
    {

        private int idField;

        private updateRequestOffrLingTaalValue[] valueField;

        /// <remarks/>
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("value")]
        public updateRequestOffrLingTaalValue[] value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class updateRequestOffrLingTaalValue
    {

        private string i18nField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string i18n
        {
            get
            {
                return this.i18nField;
            }
            set
            {
                this.i18nField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class updateRequestStatutStatuut
    {

        private int idField;

        private updateRequestStatutStatuutValue[] valueField;

        /// <remarks/>
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("value")]
        public updateRequestStatutStatuutValue[] value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class updateRequestStatutStatuutValue
    {

        private string i18nField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string i18n
        {
            get
            {
                return this.i18nField;
            }
            set
            {
                this.i18nField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class updateRequestZoneActionWerkgebied
    {

        private int idField;

        private updateRequestZoneActionWerkgebiedValue[] valueField;

        private int[] parentField;

        /// <remarks/>
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("value")]
        public updateRequestZoneActionWerkgebiedValue[] value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("parent")]
        public int[] parent
        {
            get
            {
                return this.parentField;
            }
            set
            {
                this.parentField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class updateRequestZoneActionWerkgebiedValue
    {

        private string i18nField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string i18n
        {
            get
            {
                return this.i18nField;
            }
            set
            {
                this.i18nField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class updateRequestPouvoirAgreantErkenning
    {

        private int idField;

        private updateRequestPouvoirAgreantErkenningValue[] valueField;

        /// <remarks/>
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("value")]
        public updateRequestPouvoirAgreantErkenningValue[] value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class updateRequestPouvoirAgreantErkenningValue
    {

        private string i18nField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string i18n
        {
            get
            {
                return this.i18nField;
            }
            set
            {
                this.i18nField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class updateRequestAgrementErken
    {

        private int idField;

        private updateRequestAgrementErkenValue[] valueField;

        private int pouvoirAgreantErkenningField;

        private bool pouvoirAgreantErkenningFieldSpecified;

        /// <remarks/>
        public int id
        {
            get
            {
                return this.idField;
            }
            set
            {
                this.idField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("value")]
        public updateRequestAgrementErkenValue[] value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }

        /// <remarks/>
        public int pouvoirAgreantErkenning
        {
            get
            {
                return this.pouvoirAgreantErkenningField;
            }
            set
            {
                this.pouvoirAgreantErkenningField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool pouvoirAgreantErkenningSpecified
        {
            get
            {
                return this.pouvoirAgreantErkenningFieldSpecified;
            }
            set
            {
                this.pouvoirAgreantErkenningFieldSpecified = value;
            }
        }
    }

    /// <remarks/>
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
    public partial class updateRequestAgrementErkenValue
    {

        private string i18nField;

        private string valueField;

        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string i18n
        {
            get
            {
                return this.i18nField;
            }
            set
            {
                this.i18nField = value;
            }
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this.valueField;
            }
            set
            {
                this.valueField = value;
            }
        }
    }

}
