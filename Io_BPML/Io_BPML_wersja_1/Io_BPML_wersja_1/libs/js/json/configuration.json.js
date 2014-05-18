Bizagi.AppModel = {"personalized":false,"userLogoName":"\\libs\\img\\biz-ex-logo.png","bizagiUrl":"http://www.bizagi.com","productName":"Bizagi Process Modeler","modelName":"Io_BPML_wersja_1","publishDate":"2014-05-04 00:08:26","pages":[{"id":"05396a01-24a6-4247-804e-dd24f5dc897a","name":"Diagram 1","version":"1.0","author":"Paweł","image":"files\\diagrams\\Diagram_1.png","isSubprocessPage":false,"elements":[{"id":"607b2810-d80c-4087-8948-5ecfb93c567f","name":"Process 1","elementImage":"files\\bpmnElements\\Participant.png","imageBounds":{"points":[{"x":20.0,"y":20.0}],"radius":0.0,"height":595.0,"width":50.0,"shape":"rect"},"elementType":"Participant","pageElements":[{"id":"ca24a5e3-6084-45cf-bbd6-0cb00a169488","name":"None","elementImage":"files\\bpmnElements\\NoneStart.png","imageBounds":{"points":[{"x":113.0,"y":48.0}],"radius":15.0,"height":30.0,"width":30.0,"shape":"circle"},"elementType":"NoneStart"},{"id":"fb43309b-e6da-419a-8a17-bae05906d434","name":"Dodawanie produktów do koszyka\r\n","elementImage":"files\\bpmnElements\\AbstractTask.png","imageBounds":{"points":[{"x":190.0,"y":33.0}],"radius":0.0,"height":60.0,"width":90.0,"shape":"rect"},"elementType":"AbstractTask","properties":[]},{"id":"6954d509-6b67-4189-b1c9-87c0e3481467","name":"Przeliczanie koszyka\r\n","elementImage":"files\\bpmnElements\\AbstractTask.png","imageBounds":{"points":[{"x":346.0,"y":33.0}],"radius":0.0,"height":60.0,"width":90.0,"shape":"rect"},"elementType":"AbstractTask","properties":[]},{"id":"553673bf-3632-46bd-8e00-497daaf696f1","name":"Zatwierdzenie koszyka\r\n","elementImage":"files\\bpmnElements\\AbstractTask.png","imageBounds":{"points":[{"x":490.0,"y":33.0}],"radius":0.0,"height":60.0,"width":90.0,"shape":"rect"},"elementType":"AbstractTask","properties":[]},{"id":"9535a4b6-b6c7-43f9-baf9-3366c283e6ac","name":"Forma dostawy\r\n","elementImage":"files\\bpmnElements\\AbstractTask.png","imageBounds":{"points":[{"x":643.0,"y":33.0}],"radius":0.0,"height":60.0,"width":90.0,"shape":"rect"},"elementType":"AbstractTask","properties":[]},{"id":"8d317ec1-c6ae-4384-8bff-08870c047725","name":"Sposób płatności\r\n","elementImage":"files\\bpmnElements\\AbstractTask.png","imageBounds":{"points":[{"x":783.0,"y":33.0}],"radius":0.0,"height":60.0,"width":90.0,"shape":"rect"},"elementType":"AbstractTask","properties":[]},{"id":"e452c622-4f46-4192-bd8c-002e5c3fe6a6","name":"Dodatkowe informacje\r\n","elementImage":"files\\bpmnElements\\AbstractTask.png","imageBounds":{"points":[{"x":926.0,"y":33.0}],"radius":0.0,"height":60.0,"width":90.0,"shape":"rect"},"elementType":"AbstractTask","properties":[]},{"id":"2d1bb579-903e-433a-b7e3-2e281001af7e","name":"Kliknięcie \"Realizacja zamówienia\"\r\n","elementImage":"files\\bpmnElements\\AbstractTask.png","imageBounds":{"points":[{"x":1077.0,"y":33.0}],"radius":0.0,"height":60.0,"width":90.0,"shape":"rect"},"elementType":"AbstractTask","properties":[]},{"id":"0021b35a-9fca-47b4-9f42-5ee151869528","name":"Informacja o zamówieniu\r\n","elementImage":"files\\bpmnElements\\AbstractTask.png","imageBounds":{"points":[{"x":1077.0,"y":153.0}],"radius":0.0,"height":60.0,"width":90.0,"shape":"rect"},"elementType":"AbstractTask","properties":[]},{"id":"9a5b1633-94ec-4534-af05-714c1e33c83c","name":"Weryfikacja otrzymania płatności\r\n","elementImage":"files\\bpmnElements\\AbstractTask.png","imageBounds":{"points":[{"x":927.0,"y":153.0}],"radius":0.0,"height":60.0,"width":90.0,"shape":"rect"},"elementType":"AbstractTask","properties":[]},{"id":"f0bbad8c-48bb-4370-982d-1354d709bf7f","name":"Sprawdzenie dostępności towaru","elementImage":"files\\bpmnElements\\ExclusiveGateway.png","imageBounds":{"points":[{"x":807.0,"y":272.0}],"radius":0.0,"height":40.0,"width":40.0,"shape":"poly"},"elementType":"ExclusiveGateway","properties":[],"pageElements":[{"name":"Dostępny","elementType":"SequenceFlow","properties":[]},{"name":"Niedostępny","elementType":"SequenceFlow","properties":[]}]},{"id":"5795da58-5c31-4f4c-b37d-ded38015bf21","name":"Opcje anulowania\r\n","elementImage":"files\\bpmnElements\\AbstractTask.png","imageBounds":{"points":[{"x":649.0,"y":262.0}],"radius":0.0,"height":60.0,"width":90.0,"shape":"rect"},"elementType":"AbstractTask","properties":[]},{"id":"e6e3dbe6-0fdd-4de5-bb9f-a432ec24ff02","name":"Przygotowanie towaru do wysyłki\r\n","elementImage":"files\\bpmnElements\\AbstractTask.png","imageBounds":{"points":[{"x":496.0,"y":262.0}],"radius":0.0,"height":60.0,"width":90.0,"shape":"rect"},"elementType":"AbstractTask","properties":[]},{"id":"d3d93f66-93f3-4435-91db-4ec10f5858cb","name":"Wysyłka","elementImage":"files\\bpmnElements\\AbstractTask.png","imageBounds":{"points":[{"x":349.0,"y":262.0}],"radius":0.0,"height":60.0,"width":90.0,"shape":"rect"},"elementType":"AbstractTask","properties":[]},{"id":"9fac2577-d7df-4444-9918-f959e449d825","name":"Powiadomienie o wysyłce\r\n","elementImage":"files\\bpmnElements\\AbstractTask.png","imageBounds":{"points":[{"x":205.0,"y":262.0}],"radius":0.0,"height":60.0,"width":90.0,"shape":"rect"},"elementType":"AbstractTask","properties":[]},{"id":"606d4794-7df6-4a9a-b94f-7db1ff99af39","name":"Weryfikacja dostarczenia paczki","elementImage":"files\\bpmnElements\\ExclusiveGateway.png","imageBounds":{"points":[{"x":105.0,"y":272.0}],"radius":0.0,"height":40.0,"width":40.0,"shape":"poly"},"elementType":"ExclusiveGateway","properties":[],"pageElements":[{"name":"Doręczona","elementType":"SequenceFlow","properties":[]},{"name":"Niedoręczona","elementType":"SequenceFlow","properties":[]}]},{"id":"2735febe-d191-471e-92b0-a9f1ff9a3848","name":"Koniec zlecenia","elementImage":"files\\bpmnElements\\AbstractTask.png","imageBounds":{"points":[{"x":80.0,"y":161.0}],"radius":0.0,"height":60.0,"width":90.0,"shape":"rect"},"elementType":"AbstractTask","properties":[]},{"id":"8655d767-7352-4712-9e2f-0040bb43169f","name":"None","elementImage":"files\\bpmnElements\\NoneEnd.png","imageBounds":{"points":[{"x":226.0,"y":176.0}],"radius":15.0,"height":30.0,"width":30.0,"shape":"circle"},"elementType":"NoneEnd"},{"id":"4c362a7d-1ab9-4f92-96a3-be721bca5bdf","name":"Powód","elementImage":"files\\bpmnElements\\ExclusiveGateway.png","imageBounds":{"points":[{"x":213.0,"y":381.0}],"radius":0.0,"height":40.0,"width":40.0,"shape":"poly"},"elementType":"ExclusiveGateway","properties":[],"pageElements":[{"name":"Paczka wróciła\r\n","elementType":"SequenceFlow","properties":[]},{"name":"Paczka niewróciła\r\n","elementType":"SequenceFlow","properties":[]}]},{"id":"dee34c71-b870-4628-be19-5c5a9dad3cdf","name":"Informowanie klienta i oczekiwanie na reakcję (15 dni)\r\n","elementImage":"files\\bpmnElements\\AbstractTask.png","imageBounds":{"points":[{"x":188.0,"y":540.0}],"radius":0.0,"height":60.0,"width":90.0,"shape":"rect"},"elementType":"AbstractTask","properties":[]},{"id":"2d23a1b4-3358-4a67-bae9-fbecfd225462","name":"Reakcja na decyzję klienta","elementImage":"files\\bpmnElements\\AbstractTask.png","imageBounds":{"points":[{"x":352.0,"y":540.0}],"radius":0.0,"height":60.0,"width":90.0,"shape":"rect"},"elementType":"AbstractTask","properties":[]},{"id":"244cf2db-fcb4-4a29-afb8-b1e025477950","name":"None","elementImage":"files\\bpmnElements\\NoneIntermediate.png","imageBounds":{"points":[{"x":535.0,"y":555.0}],"radius":15.0,"height":30.0,"width":30.0,"shape":"circle"},"elementType":"NoneIntermediate"},{"id":"262bdda0-9adf-4c04-8ace-61e17a665157","name":"Exclusive Gateway","elementImage":"files\\bpmnElements\\ExclusiveGateway.png","imageBounds":{"points":[{"x":363.0,"y":381.0}],"radius":0.0,"height":40.0,"width":40.0,"shape":"poly"},"elementType":"ExclusiveGateway","properties":[],"pageElements":[{"name":"Jeszcze niedoręczona\r\n","elementType":"SequenceFlow","properties":[]},{"name":"Zgubiona/zniszczona\r\n","elementType":"SequenceFlow","properties":[]}]},{"id":"94e790c0-252b-4a17-8f7b-f802acb2aa17","name":"Exclusive Gateway","elementImage":"files\\bpmnElements\\ExclusiveGateway.png","imageBounds":{"points":[{"x":656.0,"y":381.0}],"radius":0.0,"height":40.0,"width":40.0,"shape":"poly"},"elementType":"ExclusiveGateway","properties":[],"pageElements":[{"name":"Sprawdzenie dostępności towaru","elementType":"SequenceFlow","properties":[]},{"name":"Zwrot pieniędzy od kuriera","elementType":"SequenceFlow","properties":[]}]},{"id":"14f5b610-b16e-4684-a2d1-2ad917fbe8a2","name":"Oczekiwanie lub zwrot kosztów","elementImage":"files\\bpmnElements\\AbstractTask.png","imageBounds":{"points":[{"x":926.0,"y":262.0}],"radius":0.0,"height":60.0,"width":90.0,"shape":"rect"},"elementType":"AbstractTask","properties":[]},{"id":"49eaa763-7e53-4c70-9d96-e14c24224b77","name":"None","elementImage":"files\\bpmnElements\\NoneEnd.png","imageBounds":{"points":[{"x":1107.0,"y":277.0}],"radius":15.0,"height":30.0,"width":30.0,"shape":"circle"},"elementType":"NoneEnd"},{"id":"8dccb2f4-e3aa-409c-850d-ac62a86ead3f","name":"Zwrot pieniędzy od kuriera","elementImage":"files\\bpmnElements\\AbstractTask.png","imageBounds":{"points":[{"x":773.0,"y":371.0}],"radius":0.0,"height":60.0,"width":90.0,"shape":"rect"},"elementType":"AbstractTask","properties":[]},{"id":"d0147038-b783-42a6-945a-62aab172443e","name":"None","elementImage":"files\\bpmnElements\\NoneEnd.png","imageBounds":{"points":[{"x":952.0,"y":386.0}],"radius":15.0,"height":30.0,"width":30.0,"shape":"circle"},"elementType":"NoneEnd"},{"id":"6ccca83b-e529-4f8d-967a-f91fcdb4c310","name":"Czekanie (2 tygodnie)\r\n","elementImage":"files\\bpmnElements\\AbstractTask.png","imageBounds":{"points":[{"x":639.0,"y":473.0}],"radius":0.0,"height":60.0,"width":90.0,"shape":"rect"},"elementType":"AbstractTask","properties":[]},{"id":"5a55d102-2ff0-4f69-be29-3dbc1248b3d9","name":"Ręczna obsługa","elementImage":"files\\bpmnElements\\AbstractTask.png","imageBounds":{"points":[{"x":770.0,"y":473.0}],"radius":0.0,"height":60.0,"width":90.0,"shape":"rect"},"elementType":"AbstractTask","properties":[]}]}]}],"texts":{"tableOfContents":"Table of Contents","pageNumber":"Page","pageNumberLabelOf":"of","version":"Version","author":"Author","description":"Description","mainPool":"Main Process","mainPoolDescription":"Main Process Description","processDiagrams":"Process Diagrams","processElements":"Process Elements","elements":"Process Elements","defaultElementName":"Element","performers":"Performers","connectors":"Connectors","connector":"Connector","home":"Home","search":"Search","goToParentProcess":"<< Go to Parent Process","visitBizagi":"Visit bizagi.com","contains":"Contains {0} subprocesses","showAll":"Show all","fullScreen":"Full screen","zoomIn":"Zoom In","zoomOut":"Zoom Out","close":"Close","menu":"Menu: ","errorPage":"Error when visualizing page","process":"Process","subProcess":"Published subprocesses","contain":"Contains","checkAttributes":"Check attributes","checkOverview":"Check overview","unavailableResource":"Unavailable resource","localResource":"Resource can be accessed locally","performer":"Performer","linktoimage":"Link to Image","presentationAction":"Presentation Actions","searchGlobal":"Search all","searchLocal":"Search in this process","searchResults":"No Results Found","titlePage":"Start","emptyElement":"This element has not yet been documented","unsupported":"Your browser does not support content displayed by this page. <br> We recommend you upgrading your browser.","details":"Details","expand":"Expand","mainPoolProperties":"Main Process properties"},"searchMap":[{"containerId":"05396a01-24a6-4247-804e-dd24f5dc897a","containerName":"Diagram 1","isSubprocess":false,"elements":[{"id":"607b2810-d80c-4087-8948-5ecfb93c567f","value":"Process 1"},{"id":"ca24a5e3-6084-45cf-bbd6-0cb00a169488","value":""},{"id":"fb43309b-e6da-419a-8a17-bae05906d434","value":"Dodawanie produktów do koszyka\r\n"},{"id":"6954d509-6b67-4189-b1c9-87c0e3481467","value":"Przeliczanie koszyka\r\n"},{"id":"553673bf-3632-46bd-8e00-497daaf696f1","value":"Zatwierdzenie koszyka\r\n"},{"id":"9535a4b6-b6c7-43f9-baf9-3366c283e6ac","value":"Forma dostawy\r\n"},{"id":"8d317ec1-c6ae-4384-8bff-08870c047725","value":"Sposób płatności\r\n"},{"id":"e452c622-4f46-4192-bd8c-002e5c3fe6a6","value":"Dodatkowe informacje\r\n"},{"id":"2d1bb579-903e-433a-b7e3-2e281001af7e","value":"Kliknięcie \"Realizacja zamówienia\"\r\n"},{"id":"0021b35a-9fca-47b4-9f42-5ee151869528","value":"Informacja o zamówieniu\r\n"},{"id":"9a5b1633-94ec-4534-af05-714c1e33c83c","value":"Weryfikacja otrzymania płatności\r\n"},{"id":"f0bbad8c-48bb-4370-982d-1354d709bf7f","value":"Sprawdzenie dostępności towaru"},{"id":"5795da58-5c31-4f4c-b37d-ded38015bf21","value":"Opcje anulowania\r\n"},{"id":"14f5b610-b16e-4684-a2d1-2ad917fbe8a2","value":"Oczekiwanie lub zwrot kosztów"},{"id":"49eaa763-7e53-4c70-9d96-e14c24224b77","value":""},{"id":"e6e3dbe6-0fdd-4de5-bb9f-a432ec24ff02","value":"Przygotowanie towaru do wysyłki\r\n"},{"id":"d3d93f66-93f3-4435-91db-4ec10f5858cb","value":"Wysyłka"},{"id":"9fac2577-d7df-4444-9918-f959e449d825","value":"Powiadomienie o wysyłce\r\n"},{"id":"606d4794-7df6-4a9a-b94f-7db1ff99af39","value":"Weryfikacja dostarczenia paczki"},{"id":"2735febe-d191-471e-92b0-a9f1ff9a3848","value":"Koniec zlecenia"},{"id":"8655d767-7352-4712-9e2f-0040bb43169f","value":""},{"id":"4c362a7d-1ab9-4f92-96a3-be721bca5bdf","value":"Powód"},{"id":"dee34c71-b870-4628-be19-5c5a9dad3cdf","value":"Informowanie klienta i oczekiwanie na reakcję (15 dni)\r\n"},{"id":"2d23a1b4-3358-4a67-bae9-fbecfd225462","value":"Reakcja na decyzję klienta"},{"id":"262bdda0-9adf-4c04-8ace-61e17a665157","value":""},{"id":"94e790c0-252b-4a17-8f7b-f802acb2aa17","value":""},{"id":"8dccb2f4-e3aa-409c-850d-ac62a86ead3f","value":"Zwrot pieniędzy od kuriera"},{"id":"d0147038-b783-42a6-945a-62aab172443e","value":""},{"id":"6ccca83b-e529-4f8d-967a-f91fcdb4c310","value":"Czekanie (2 tygodnie)\r\n"},{"id":"5a55d102-2ff0-4f69-be29-3dbc1248b3d9","value":"Ręczna obsługa"},{"id":"244cf2db-fcb4-4a29-afb8-b1e025477950","value":""}]}]}