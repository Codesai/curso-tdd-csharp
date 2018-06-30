# Tire Pressure Monitoring System Variation

## Goal
Be able to test `Alarm`'s `check` function without changing the method signature.

1. Test the code using test doubles created by you.

2. Test the code using test doubles created with a library.

## Tools
[NSubstitute](http://nsubstitute.github.io/)

### Example of mock
```csharp
[Fact]
public void should_interact_with_the_mock() {
    collaborator = Substitute.For<Collaborator>();       
    MyClass myClass = new MyClass(collaborator);

    myClass.Run();

    collaborator.Received().Collaborate();
}
```

### Example of stub

```csharp
[Fact]
public void should_retrieve_the_stub_response(){
    collaborator = Substitute.For<Collaborator>();
    String response = "collaborator response";
    calculator.Collaborate().Returns(response);
    MyClass myClass = new MyClass(collaborator);

    String result = myClass.Run();

    Assert.Equal(response, result);
}
```

## Learnings
How to build a Spy and a Stub manually.

How to use NSubstitute to generate the test doubles.

## References

Based on an exercise from [Luca Minudel](https://twitter.com/lukadotnet?lang=en)'s [TDD with Mock Objects And Design Principles exercises](https://github.com/lucaminudel/TDDwithMockObjectsAndDesignPrinciples)

