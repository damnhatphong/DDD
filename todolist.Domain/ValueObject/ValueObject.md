### What is ValueObject? What is it role in DDD?

An object that represents a descriptive aspect of the domain with no conceptual identity is called a Value Object. 
Value Objects are instantiated to represent elements of the design that we care about only for what they are, not who or which they are.

Value objects are different from entities - they don't have a concept of identity. 
They encapsulate primitive types in the domain and solve primitive obsession.
https://refactoring.guru/smells/primitive-obsession

There are two main qualities of Value Objects:

- They are immutable
- They have no identity
- 
Another quality of value objects is structural equality. Two value objects are equal if their values are the same. This quality is the least important in practice.
However, there are cases where you want only some values to determine equality.
### What are the differences between value objects and entities?
In DDD, you model your business cases using domain objects. 

These objects can fall into 2 categories: entities and value objects. 
- <b>Entites</b> have a natural key to identify them.
- whereas <b>value objects</b> are solely identified by their value.

### When to use value object?

When the object does not have it own entity, it has no meaning standing alone but to be attached to the domain entities.

### How to implement value object in C#?

Remember, value object is immutable, which mean can not be changed after creation.

You can use a record or ValueObject base class to represent value objects. 
This should depend on your specific requirements and the complexity of your domain. 
I use records by default unless I need some qualities of a ValueObject base class. For example, 
a base class is practical when you want to control equality components.

### Domain Entity, Value Object and Aggregates, how is it represented in relational database tables?

EF Core entities are in different context with DDD entities, don't mistake the two.

For example in this context (TodoList application). with the following schema

TodoItem (entity)
- title (string)
- content (string)
- description (Description type) - Value Object
- metadata (Metadata type) - Value Object

There are multiple way to design the database schema based on the above entity schema

- You can put both description and metadata to the same TodoItem table, 
and use mapper to map the object and value back to the domain entity, check this out https://learn.microsoft.com/en-us/ef/core/modeling/owned-entities

- Or you can separate Description and Metadata to differnt table in the database schema and
has reference 1-1 to the TodoItem table, later to be mapped back to the Domain Entity. Check this out https://devblogs.microsoft.com/dotnet/announcing-ef8-rc1/#complex-types-as-value-objects


### Example of Value Object?
In the current context todo app, for example, we only care about the todoitem,
and it acts as an domain entity in our system (it has and ID so we can distinguish each item)

The todoitem consists of multiple things, the title, the content, the description, the metadata.

Title and content can be primitive string values, where as description and metadata are complex objects and since we only care about their values,
and they do not have their own entity, they are value objects.
