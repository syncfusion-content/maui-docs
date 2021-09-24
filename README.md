# Documentation Guidelines 

This section contains guidelines on naming files, sections, documents and other document elements.

> **NOTE**: Some of the items are marked as TODO which will be documented later.

## File naming Convention:
* All files should have `.md` extension.
* Separate words in file names should be hyphenated
* File names of the documents should have one or two-word names that describe the material covered in the document. 
* The full title of the document should be in the file name. 
* Phrase title and description in a way that users can determine what questions the text will answer, and material that will be addressed, without reading the content. This eases the time spent looking for answers, and improvises search/scanning, and possibly **SEO**.
* Provide titles and headers in the form of “Using foo” over “How to Foo.”

> For example, at the top section of each MD file,

> **Title :** Getting started with Chart widget for Syncfusion Essential JS 

> **Description :** How to create a chart, add series, enable tooltip and other functionalities.


## Markdown Syntax Guideline
* Follow the syntax mentioned in this [link](http://kramdown.gettalong.org/syntax.html) for most of the elements. There are some elements which need special styling or additional settings to do. Those have been described in the below topics.

## General
* Do not bold the words unnecessarily.
* Use [inline code style](http://kramdown.gettalong.org/quickref.html#inline-code) wherever it is possible to highlight the keywords, variables or one line code examples that come within the paragraph.

### Cross-reference
* Link within the page (if you have a title with space, use hyphen (-))

>	**Syntax**: \[Link name](#title-name)

>	**Example**: \[How to best read this user guide] (#how-to-best-read-this-user-guide)

* Link to the other page within the same platform documentation (using relative path). Tooltip text is optional.

> **Syntax**: \[Link name](relative path "Tooltip text")

> **Example**: \[Barcode](/js/Barcode/Getting-Started "Barcode Getting Started")

### Table
* Use the [kramdown syntax](http://kramdown.gettalong.org/syntax.html#tables) for creating the tables.
* **Advanced tables**: If you want to create an advanced tables with row span or column span or with code snippets, you can go with the standard html table syntax as described below.

> 1. start with `<table>` tag. Tag should be left indented and should have empty space in left side. 

> 2. Provide `TH` tag for table headers.

> 3. Code snippet can include within `<td> [code snippet] </td>`. Follow the same pattern like code snippet. 

* Do not provide table captions.
* You should use the below markdown syntax if you want to use markdown syntax within the html tags.

> \{{'<MarkdownSyntax>' | markdownify }}

> **Example**:

> \{{'\[syncfusion](http://cdn.syncfusion.com/js/assets/external/jquery-1.10.2.min.js)'| markdownify }}



### Image

* Make sure image is not resized or blurred. 
* Caption is not necessary to provide for all images except for the case where we will have displayed more than one image.

* Adding Image : General markdown [syntax](http://kramdown.gettalong.org/syntax.html#images) will work.

> **Syntax**: \!\[Alt text](imagepath)

> **Example**: \!\[Alt text](/path/to/img.jpg)

* Adding image with caption:

> **Syntax**: \{% include image.html url="image path" caption="caption text"%}

> **Example**: \{% include image.html url="/js/DatePicker/Appearance-and-Styling_images/Appearance-and-Styling_img2.png" caption="caption text"%}

* Maximum width of the image should be 750 PX
* Maximum height of the image should be 550 PX
* Image format should be either .jpeg or .png format 
* Size of the image should not exceed  20 to 40 KB  
* If you are including the image to show an output of a code block, make sure the exact output can see the user also when he executes the same code snippet.

### Code Blocks
* Refer [this page](http://haisum.github.io/2014/11/07/jekyll-pygments-supported-highlighters/) for Code block syntax and supported languages.
* Align the code snippets using following free formatters:
	[JS](http://jsbeautifier.org/) ,
	[HTML](http://www.freeformatter.com/html-formatter.html)
* Remove extra lines added within the code block.
* Make sure the given code block runs without any issues.
* JSRender template syntax can be rendered by the following syntax :

> \{{"{{"}} code block here {{}}}}


### Bullet style
* Refer the syntax provided in the [Kramdown site](http://kramdown.gettalong.org/syntax.html#lists).
* Do not provide a line gap between the bullet points.

### Notes style

* To add the different type of predefined blockqoute use the below syntax. Since we will insert the title or relevant icon for this block of content, do not add the **"Title"**. 

**Information** or **Notes**
> **Syntax**: I> [Content]

> **Example**:  Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis volutpat, elit eget iaculis venenatis

**Warning**
> **Syntax**: W> [Content]

> **Example**:  Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis volutpat, elit eget iaculis venenatis

**Errors**
> **Syntax**: E> [Content]

> **Example**:  Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis volutpat, elit eget iaculis venenatis

**Tips**
> **Syntax**: T> [Content]

> **Example**:  Lorem ipsum dolor sit amet, consectetur adipiscing elit. Duis volutpat, elit eget iaculis venenatis

### Notes multiple paragraph style
* Use the BR tag between the content to enable multiple paragraph style.  


**Tips**
> **Syntax**: T> [Content]

> **Example**:  Lorem ipsum dolor sit amet, consectetur adipiscing elit. **<BR>**Duis volutpat, elit eget iaculis venenatis



### See also

* See also section can be added at the bottom of the page using the below syntax 

> **Syntax**:
> {% seealso %}
>     [Content]
> {% endseealso %}


> **Example**: 
> {% seealso %}
>    [See the Cross Reference section](#Cross-reference)
> {% endseealso %}


### JS Playground integration
* Todo -> How to link the JS Playground link on top of the each code blocks?

### Keyboard shortcuts
* Enclose the each keys with `<kbd>` tag to display the keys with different styling. For ex, <kbd>Ctrl</kbd>+<kbd>A</kbd> .

### Product Release Version variable 
* To add the version number in the documentation, use the below variables that replace the corresponding release version number while publishing. So that, always your content will contains the latest release version number. 

| Variable Name     	           | Output         | Description            					                             |  
| ---------------------------------|:--------------:|:----------------------------------------------------------------------:|  
| {{ site.releaseversion }}        | 13.2.0.29      |Syncfusion Essential Studio version                                     |  
| {{ site.20esreleaseversion }}    | 13.1200.0.29   |Syncfusion Essential Studio assemblies version for .NET Framework 2.0   |  
| {{ site.35esreleaseversion }}    | 13.1350.0.29   |Syncfusion Essential Studio assemblies version for .NET Framework 3.5   |  
| {{ site.40esreleaseversion }}    | 13.1400.0.29   |Syncfusion Essential Studio assemblies version for .NET Framework 4.0   |  
| {{ site.45esreleaseversion }}    | 13.1450.0.29   |Syncfusion Essential Studio assemblies version for .NET Framework 4.5   |  
| {{ site.451esreleaseversion }}   | 13.1451.0.29   |Syncfusion Essential Studio assemblies version for .NET Framework 4.5.1 |  
| {{ site.mvc3releaseversion }}    | 13.1300.0.29   |Syncfusion Essential Studio assemblies based on MVC Version 3.0         |  
| {{ site.mvc4releaseversion }}    | 13.1400.0.29   |Syncfusion Essential Studio assemblies based on MVC Version 4.0         |  
| {{ site.mvc5releaseversion }}    | 13.1500.0.29   |Syncfusion Essential Studio assemblies based on MVC Version 5.0         |  

## API Reference Guideline

### Naming Standards
* Use the JS API naming standards mentioned in the following page - [API Naming Standards](https://syncfusion.atlassian.net/wiki/display/JS/API+Naming+Standards)

# See Also
[Style Guide](/style-guide.md)