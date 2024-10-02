
using GenericClassImplementation;

ClassHelpes classHelpes = new ClassHelpes();

ClassType1 classType1 = new ClassType1()
{
    Name = "Foo",
    Description = "Bar",
};

ClassType2 classType2 = new ClassType2()
{
    Name= "Bar",
    Description = "Foo",
    Type = "Type2"
};

ClassType3 classType3 = new ClassType3()
{
    Name = "Bar",
    Description = "Foo",
    Question = "Type3"
};

classHelpes.ImportInfo(ClassHelpes.TypeEnum.Type1, classType1);
classHelpes.ImportInfo(ClassHelpes.TypeEnum.Type2, classType2);
classHelpes.ImportInfo(ClassHelpes.TypeEnum.Type3, classType3);

