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

* The [`dataManager`]() property is used to define the data source either as a collection of objects or as an instance of `DataManager` that needs to be populated in the diagram.

* The [`ID`]() property is used to define the unique field of each JSON data.

* The [`parentId`]() property is used to defines the parent field which builds the relationship between ID and parent field.

* The [`root`]() property is used to define the root node for the diagram populated from the data source.

* To explore those properties, see [`DataSourceSettings`]().

## See Also

* [How to arrange the diagram nodes and connectors using various layout](./automatic-layout)
