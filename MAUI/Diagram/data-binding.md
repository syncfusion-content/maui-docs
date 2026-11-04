---
layout: post
title: Data Binding in MAUI Diagram | Syncfusion®
description: Populate the MAUI Diagram from local or remote data sources and perform CRUD operations on nodes and connectors.
platform: maui
control: SfDiagram
documentation: ug
appliesto: UI Component Suite, Diagram SDK
---

# Data Binding in .NET MAUI Diagram

* Diagram can be populated with the `nodes` and `connectors` based on the information provided from an external data source.

* Diagram exposes its specific data-related properties allowing you to specify the data source fields from where the node information has to be retrieved from.

* The [`dataManager`](../api/diagram/dataSourceModel#datamanager) property is used to define the data source either as a collection of objects or as an instance of `DataManager` that needs to be populated in the diagram.

* The [`ID`](../api/diagram/dataSourceModel#id) property is used to define the unique field of each JSON data.

* The [`parentId`](../api/diagram/dataSourceModel#parentid) property is used to defines the parent field which builds the relationship between ID and parent field.

* The [`root`](../api/diagram/dataSourceModel#root) property is used to define the root node for the diagram populated from the data source.

* To explore those properties, see [`DataSourceSettings`](../api/diagram/dataSourceModel).

## CRUD

This feature allows you to read the data source and perform add or edit or delete the data in data source at runtime.

## Read DataSource

* This feature allows you to define the nodes and connectors collection in the data source and connectionDataSource respectively.

* You can set the data collection in the model’s dataSourceSettings [`dataSource`](../api/diagram/dataSourceModel#datasource) property. The nodes will be generated based on the data specified in the data source.

* You can set the connector collection in the model’s dataSourceSettings [`connectionDataSource`](../api/diagram/dataSourceModel#connectiondatasource) property.

* The dataSourceSettings connectionDataSource [`dataManager`](../api/diagram/connectionDataSourceModel#datamanager) property is used to set the data source for the connection data source items.

* If you have a data (data will be set in the dataSource property) with parent relationship in the database and also defined the connector in the connectionDataSource simultaneously, then the connectors set in the connectionDataSource will be considered as a priority to render the connector.

* The dataSourceSettings [`crudAction’s`](../api/diagram/dataSourceModel#crudaction) [`read`](../api/diagram/crudActionModel#read) property specifies the method, which is used to read the data source and its populate the nodes in the diagram.

* The connectionDataSource crudAction’s [`read`](../api/diagram/crudActionModel#read) specifies the method, which is used to read the data source and its populates the connectors in the diagram.

* The dataSourceSettings’s [`id`](../api/diagram/dataSourceModel#id) and connectionDataSource’s [`id`](../api/diagram/connectionDataSourceModel#id) properties are used to define the unique field of each JSON data.

* The connectionDataSource’s [`sourceID`](../api/diagram/connectiondatasourcemodel#sourceid) and [`targetID`](../api/diagram/connectiondatasourcemodel#targetid) properties are used to set the sourceID and targetID for connection data source item.

* The connectionDataSource’s [`sourcePointX`](../api/diagram/connectiondatasourcemodel#sourcepointx), [`sourcePointY`](../api/diagram/connectiondatasourcemodel#sourcepointy), [`targetPointX`](../api/diagram/connectiondatasourcemodel#targetpointx), and [`targetPointY`](../api/diagram/connectiondatasourcemodel#targetpointy) properties are used to define the sourcePoint and targetPoint values for connector from data source.

* The dataSourceSettings crudAction’s [`customFields`](../api/diagram/crudActionModel#customfields) property is used to maintain the additional information for nodes.

* Similarly, connectionDataSource’s crudAction’s [`customFields`](../api/diagram/crudActionModel#customfields) is used to maintain the additional information for connectors.

{% tabs %}
{% highlight ts tabtitle="index.ts" %}
{% include code-snippet/diagram/dataBinding-cs6/index.ts %}
{% endhighlight %}
{% highlight html tabtitle="index.html" %}
{% include code-snippet/diagram/dataBinding-cs6/index.html %}
{% endhighlight %}
{% endtabs %}
          
{% previewsample "page.domainurl/code-snippet/diagram/dataBinding-cs6" %}

## How to perform Editing at runtime

* The dataSourceSettings crudAction object allows you to define the method, which is used to get the changes done in the data source defined for shapes from the client-side to the server-side.

* Similarly, the connectionDataSource crudAction object allows you to define the method, which is used to get the changes done in the data source defined for connectors from the client-side to the server-side.

## InsertData

* The dataSourceSettings crudAction’s [`create`](../api/diagram/crudActionModel#create) property specifies the method, which is used to get the nodes added from the client-side to the server-side.

* The connectionDataSource crudAction’s  [`create`](../api/diagram/crudActionModel#create) specifies the method, which is used to get the connectors added from the client-side to the server-side.

* The following code example illustrates how to send the newly added or inserted data from the client to server-side.

```ts

//Initialize TypeScript Diagram
let diagram: Diagram = new Diagram({
     dataSourceSettings: {
       crudAction:
        {
            //Url which triggers the server side AddNodes method
            create: 'https://ej2services.syncfusion.com/development/web-services/api/Crud/AddNodes',
        },
     }
     connectionDataSource: {
            crudAction: {
                //Url which triggers the server side AddConnectors method
                create: 'https://ej2services.syncfusion.com/development/web-services/api/Crud/AddConnectors',
            }
     }
});
diagram.appendTo('#diagram');
//Sends the newly added nodes/connectors from client side to the server side through the URL which is specified in server side.
diagram.insertData();

```

## UpdateData

* The dataSourceSettings crudAction’s [`update`](../api/diagram/crudActionModel#update) property specifies the method, which is used to get the modified nodes from the client-side to the server-side.

* The connectionDataSource crudAction’s [`update`](../api/diagram/crudActionModel#update) specifies the method, which is used to get the modified connectors from the client-side to the server-side.

* The following code example illustrates how to send the updated data from the client to the server side.

```ts

//Initialize diagram
let diagram: Diagram = new Diagram({
     dataSourceSettings: {
       crudAction:
        {
           //Url which triggers the server side UpdateNodes method
           update: 'https://ej2services.syncfusion.com/development/web-services/api/Crud/UpdateNodes',
        },
     }
     connectionDataSource: {
        crudAction: {
           //Url which triggers the server side UpdateConnectors method
           update: 'https://ej2services.syncfusion.com/development/web-services/api/Crud/UpdateConnectors',
        }
     }
});
diagram.appendTo('#diagram');
//Sends the updated nodes/connectors from client side to the server side through the URL which is specified in server side.
diagram.updateData();

```

## DeleteData

* The dataSourceSettings crudAction’s [`destroy`](../api/diagram/crudActionModel#destroy) property specifies the method, which is used to get the deleted nodes from the client-side to the server-side.

* The connectionDataSource crudAction’s [`destroy`](../api/diagram/crudActionModel#destroy) specifies the method, which is used to get the deleted connectors from the client-side to the server-side.

```ts

//Initialize TypeScript Diagram
let diagram: Diagram = new Diagram({
     dataSourceSettings: {
       crudAction:
        {
          //Url which triggers the server side DeleteNodes method
          destroy: 'https://ej2services.syncfusion.com/development/web-services/api/Crud/DeleteNodes',
        },
     }
     connectionDataSource: {
        crudAction: {
           //Url which triggers the server side DeleteConnectors method
           destroy: 'https://ej2services.syncfusion.com/development/web-services/api/Crud/DeleteConnectors',
        }
     }
});
diagram.appendTo('#diagram');
//Sends the deleted nodes/connectors from client side to the server side through the URL which is specified in server side.
diagram.removeData();

```

## See Also

* [How to arrange the diagram nodes and connectors using various layout](./automatic-layout)
