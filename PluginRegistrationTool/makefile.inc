!INCLUDE $(INETROOT)\build\makefile.inc
NAMESPACE_SDK=CrmSdk

# Generate the strong-types
$(OBJ_PATH)\$(O)\GeneratedTypes.cs:
	$(TARGETPATH)\$(BUILDTARGET)\CrmSvcUtil.exe /nologo /url:$(TARGETPATH)\$(BUILDTARGET)\src\data\database\$(O)\newimport.xml /namespace:$(NAMESPACE_SDK) /metadataproviderservice:CrmSdk.Extensions.XmlMetadataReader,CrmSvcUtil.QA.Extensions /out:$@
