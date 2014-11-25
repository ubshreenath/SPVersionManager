SPVersionManager
================

SharePoint Document Modifier Tool - Server Desktop App for bulk updating the Created/Modified Dates and Created By/Modified By fields of documents in an SP DocLib

This tool needs access to the Server OM and thus runs only on a server running SharePoint.

 - Use it to modify the Created By / Modified By fields of a Document in a Document Library.
 - Use it to modify the Created / Modified fields of a Document in a Document Library.
 
This tool cannot be used to modify the dates/users of various versions of a document on a SPDocLib - The SharePoint OM provides no interface to do so. 
This restriction applies to document libraries that have Version Control turned on.

Tool built for SharePoint 2010. Not tested on other versions. Not extensively tested for bugs and other issues. Use at your own risk.

Many Usability enhancements have been made over time to speed up the use of the tool and reduce the number of clicks/typing that need to be done for bulk updates.
These enhancements may make the tool to appear to do weird things by itself but it is designed to do so to ensure low human error probability and better work efficiency.

Hope it helps someone else who had to do the same thing I was asked to do.