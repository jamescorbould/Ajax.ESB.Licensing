namespace Ajax.ESB.Licensing.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"GetLicenceKeyV1_20150611.GetKey+GetLicenceKey", typeof(global::GetLicenceKeyV1_20150611.GetKey.GetLicenceKey))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"Ajax.ESB.Licensing.InternalSchemas.CallSprocGetLicenceKey_20150612+GetLicenceKey", typeof(global::Ajax.ESB.Licensing.InternalSchemas.CallSprocGetLicenceKey_20150612.GetLicenceKey))]
    public sealed class GetKey_To_CallSprocGetKey : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0"" version=""1.0"" xmlns:ns0=""http://schemas.microsoft.com/Sql/2008/05/Procedures/dbo"" xmlns:ns3=""http://schemas.datacontract.org/2004/07/System.Data"" xmlns:s0=""http://Ajax.ESB.Licensing/GetProductKey/20150611/v1"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:GetLicenceKey"" />
  </xsl:template>
  <xsl:template match=""/s0:GetLicenceKey"">
    <ns0:GetLicenceKey>
      <ns0:CustomerID>
        <xsl:value-of select=""CustomerID/text()"" />
      </ns0:CustomerID>
      <ns0:ProductID>
        <xsl:value-of select=""ProductID/text()"" />
      </ns0:ProductID>
    </ns0:GetLicenceKey>
  </xsl:template>
</xsl:stylesheet>";
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"GetLicenceKeyV1_20150611.GetKey+GetLicenceKey";
        
        private const global::GetLicenceKeyV1_20150611.GetKey.GetLicenceKey _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"Ajax.ESB.Licensing.InternalSchemas.CallSprocGetLicenceKey_20150612+GetLicenceKey";
        
        private const global::Ajax.ESB.Licensing.InternalSchemas.CallSprocGetLicenceKey_20150612.GetLicenceKey _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"GetLicenceKeyV1_20150611.GetKey+GetLicenceKey";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"Ajax.ESB.Licensing.InternalSchemas.CallSprocGetLicenceKey_20150612+GetLicenceKey";
                return _TrgSchemas;
            }
        }
    }
}
