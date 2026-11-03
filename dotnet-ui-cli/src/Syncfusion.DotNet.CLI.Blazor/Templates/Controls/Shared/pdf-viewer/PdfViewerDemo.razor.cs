namespace __PAGE_NAMESPACE__;

public partial class PdfViewerDemo
{
    // A small, bundled one-page PDF keeps this sample independent of remote servers and CORS.
    private const string SampleDocument = "data:application/pdf;base64," +
        "JVBERi0xLjQKMSAwIG9iago8PCAvVHlwZSAvQ2F0YWxvZyAvUGFnZXMgMiAwIFIgPj4KZW5kb2JqCjIgMCBvYmoKPDwgL1R5cGUg" +
        "L1BhZ2VzIC9LaWRzIFszIDAgUl0gL0NvdW50IDEgPj4KZW5kb2JqCjMgMCBvYmoKPDwgL1R5cGUgL1BhZ2UgL1BhcmVudCAyIDAg" +
        "UiAvTWVkaWFCb3ggWzAgMCA2MTIgNzkyXSAvUmVzb3VyY2VzIDw8IC9Gb250IDw8IC9GMSA0IDAgUiA+PiA+PiAvQ29udGVudHMg" +
        "NSAwIFIgPj4KZW5kb2JqCjQgMCBvYmoKPDwgL1R5cGUgL0ZvbnQgL1N1YnR5cGUgL1R5cGUxIC9CYXNlRm9udCAvSGVsdmV0aWNh" +
        "ID4+CmVuZG9iago1IDAgb2JqCjw8IC9MZW5ndGggMTQwID4+CnN0cmVhbQpCVCAvRjEgMjQgVGYgNzIgNzAwIFRkIChXZWxjb21l" +
        "IHRvIFN5bmNmdXNpb24gUERGIFZpZXdlcikgVGogL0YxIDEyIFRmIDAgLTM2IFRkIChPcGVuIHlvdXIgb3duIFBERiB3aXRoIHRo" +
        "ZSB0b29sYmFyIHRvIGV4cGxvcmUgbW9yZS4pIFRqIEVUCmVuZHN0cmVhbQplbmRvYmoKeHJlZgowIDYKMDAwMDAwMDAwMCA2NTUz" +
        "NSBmIAowMDAwMDAwMDA5IDAwMDAwIG4gCjAwMDAwMDAwNTggMDAwMDAgbiAKMDAwMDAwMDExNSAwMDAwMCBuIAowMDAwMDAwMjQx" +
        "IDAwMDAwIG4gCjAwMDAwMDAzMTEgMDAwMDAgbiAKdHJhaWxlcgo8PCAvU2l6ZSA2IC9Sb290IDEgMCBSID4+CnN0YXJ0eHJlZgo1" +
        "MDEKJSVFT0YK";
}
