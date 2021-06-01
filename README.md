# PC BBUILD STORE with C# design patterns
Computer shop through which the user can build their own configurations

The idea of the project is to combine several patterns to create a project with one goal. To enable users to construct computer configurations with the help of the console, thanks to the patterns, which with fewer events and changes in fewer classes can be implemented in a demo.

The project covers the requirements for a course project (at least one creative pattern, at least one structural and at least one behavioral). The project is consistent with the compatibility of all patterns. The documentation from the following link is used: https://citeseerx.ist.psu.edu/viewdoc/download?doi=10.1.1.53.1979&rep=rep1&type=pdf

Mostly the choice refers to the following scheme:
![Screenshot](https://user-images.githubusercontent.com/20745096/120369730-5ce5d980-c31c-11eb-830b-7b77188708f6.png)

The architecture of the project is divided into two classes of libraryes. In the first class the library is the essence of the patterns, at the next level follow the folders, which are named according to the specific pattern. In the next cas libralli is the executable part of the project, which has a connection with the other classlibrali so that it can bring them together in one executable class.

#Builder
- The builder is built using six classes. The first class is ComputerBuilder, which contains seven override methods to be able to create properties from the inheriting class, namely PcBuilder. A LaptopBuilder is an analog copy of a ComputerBuilder class and has the same purpose and destination. The PC class contains a constructor, an index, and a Show method that shapes the display of user data. The next class is PcBuilder, which is the basis of functionality due to its abstract creative methods because it is inherited from other classes. The Shop class is again a constructor that builds PcBuilder.

#Composite
-  BuilderBase is an abstract class, which as an abstract should be inherited from the other classes in order to access the variables and methods that are defined in it. CompositeBuilder inherits Builde Base, as well as the IБuildОperations interface. It is used to add and remove configurations, as well as to calculate the total final price. IbuildOperations is an interface that serves to remove and add. SingleBuild is an analogue (category) of CompositeБuild and work in the same way.

#Decorator
-  BuildedPc is a class who contain only two property which are for the name and price of the project. Order class inherits Orderbase and contains a method that calculates the price when the configuration is pre-ordered. Order class inherits OrderBase and contains a method that calculates the price when the configuration is pre-ordered. Preorder class contains information for calculating pre-ordered configurations. Last but not least is the second class of laibriars, which contains the executable class Program where methods, objects are accessed and called and created and the final results are printed in the console.

![Screenshot2](https://user-images.githubusercontent.com/20745096/120384201-83ad0b80-c32e-11eb-8aab-b7f551dc99a9.png)
