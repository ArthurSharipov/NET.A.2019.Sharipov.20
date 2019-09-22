# Day - 20
The text file stores line-by-line information about URLS represented as
<scheme>://<host>/<URL‐path>?<parameters>, where the parameters segment is a set of pairs of the form key=value, with
the URL‐path and parameters segments or the parameters segment may be missing.
Develop a type system (guided by SOLID principles) to export the data obtained
based on parsing the text file information, into an XML document by the following rule, for example, for
text file with URLS:  
https://github.com/AnzhelikaKravchuk?tab=repositories   
https://github.com/AnzhelikaKravchuk/2017-2018.MMF.BSU    
https://habrahabr.ru/company/it-grad/blog/341486/   
the result is an XML document of the form (you can use any XML technology without restrictions).
