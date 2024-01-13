Adapter pattern practise

BooksData Service returns XML 
Library Service returns JSON 

Books Service (client) wants to use both but expects XML

Use adapter around Library Service (adaptee) to covert it to XML

Books Service uses adapter to get correct xml data from library service