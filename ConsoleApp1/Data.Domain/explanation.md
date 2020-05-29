when i class has a list of other class
but this class has not lint on lit
that means one to many
the class should have the list
another class have the type and the id of it


one class has a list of other and the other
has a list of it so there is many to many
and must be have  a common entity

one class as a object of other not list its called one to one


to make a one to one relationship
the author must have  a authorbiography type declaration
and the authorbiography must have a authorId
thats it to further configuration needed



to make a many to many relationsip
we need a addtioal entity
lie 
if the Book and the Category has many to many relationship
then the pivot Entity will be
BookCategory
and it will have both the bookId and the authorId
with the book type and author type
total four public fileld


and the onmodel create the in the fluent APi

you have to tell the BookCategory Entity
has a key composed of the samuraiId and the BattleId
the both two key create a anon object and it will be the key of the Entity
so this entity keep track of the object that composed of the two key which 
is also the foreign key of the two table