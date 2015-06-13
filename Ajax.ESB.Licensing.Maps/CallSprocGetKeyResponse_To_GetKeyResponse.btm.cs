namespace Ajax.ESB.Licensing.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Ajax.ESB.Licensing.InternalSchemas.CallSprocGetLicenceKey_20150612+GetLicenceKeyResponse", typeof(global::Ajax.ESB.Licensing.InternalSchemas.CallSprocGetLicenceKey_20150612.GetLicenceKeyResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"GetLicenceKeyV1_20150611.GetKey+GetLicenceKeyResponse", typeof(global::GetLicenceKeyV1_20150611.GetKey.GetLicenceKeyResponse))]
    public sealed class CallSprocGetKeyResponse_To_GetKeyResponse : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 s1"" version=""1.0"" xmlns:s1=""http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo"" xmlns:s0=""http://schemas.datacontract.org/2004/07/System.Data"" xmlns:ns0=""http://Ajax.ESB.Licensing/GetProductKey/20150611/v1"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s1:GetLicenceKeyResponse"" />
  </xsl:template>
  <xsl:template match=""/s1:GetLicenceKeyResponse"">
    <ns0:GetLicenceKeyResponse>
      <xsl:attribute name=""MinorVersion"">
        <xsl:text>1.0</xsl:text>
      </xsl:attribute>
      <LicenceKey>
        <xsl:value-of select=""s1:ReturnValue/text()"" />
      </LicenceKey>
    </ns0:GetLicenceKeyResponse>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"Ajax.ESB.Licensing.InternalSchemas.CallSprocGetLicenceKey_20150612+GetLicenceKeyResponse";
        
        private const global::Ajax.ESB.Licensing.InternalSchemas.CallSprocGetLicenceKey_20150612.GetLicenceKeyResponse _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"GetLicenceKeyV1_20150611.GetKey+GetLicenceKeyResponse";
        
        private const global::GetLicenceKeyV1_20150611.GetKey.GetLicenceKeyResponse _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"Ajax.ESB.Licensing.InternalSchemas.CallSprocGetLicenceKey_20150612+GetLicenceKeyResponse";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"GetLicenceKeyV1_20150611.GetKey+GetLicenceKeyResponse";
                return _TrgSchemas;
            }
        }
    }
}
