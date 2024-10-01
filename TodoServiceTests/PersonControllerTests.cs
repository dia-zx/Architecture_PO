using Lesson11.Controllers;
using Lesson11.Servises.Repositories.PersonsRepository;
using Lesson11.Servises.Repositories.PersonsRepository.Model;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System.Collections.Generic;
namespace TodoServiceTests;

public class PersonControllerTests
{
    private PersonsController _personsController;
    private Mock<IPersonsRepository> _personsRepositoryMock;

    public PersonControllerTests()
    {
        _personsRepositoryMock = new Mock<IPersonsRepository>();
        _personsController = new(null, _personsRepositoryMock.Object);
    }

    [Fact]
    public void GetAllTest()
    {
        List<Person> persons = Enumerable.Range(0, 5).Select(x => new Person()).ToList();

        _personsRepositoryMock.Setup(x => x.GetAll()).Returns(persons);

        var result = _personsController.GetAll();
        Assert.NotNull(result);
        Assert.IsType<OkObjectResult>(result.Result);
        _personsRepositoryMock.Verify(x => x.GetAll(), Moq.Times.AtLeastOnce);
        Assert.IsAssignableFrom<List<Person>>(((OkObjectResult)result.Result).Value);
        Assert.Equal(persons.Count, ((List<Person>)((OkObjectResult)result.Result).Value).Count);
    }

    public static object[][] _IdMassive = [[1], [20], [30],];
    [Theory]
    [MemberData(nameof(_IdMassive))]
    public void GetByIdTest(int _id)
    {

        Person person = new Person { Id = _id, Name = "Сергей" };

        _personsRepositoryMock.Setup(x => x.GetById(It.IsAny<int>())).Returns(person);

        var result = _personsController.GetById(_id);
        Assert.NotNull(result);
        Assert.IsType<OkObjectResult>(result.Result);
        _personsRepositoryMock.Verify(x => x.GetById(_id), Moq.Times.AtLeastOnce);
        Assert.IsAssignableFrom<Person>(((OkObjectResult)result.Result).Value);
        Assert.Equal(_id, ((Person)((OkObjectResult)result.Result).Value).Id);
        Assert.Equal("Сергей", ((Person)((OkObjectResult)result.Result).Value).Name);
    }

    public static object[][] _IdDeleeteMassive = { [11, 1], [2, 0], [3, 1], };
    [Theory]
    [MemberData(nameof(_IdDeleeteMassive))]
    public void DeleteTest(int _id, int answer)
    {
        _personsRepositoryMock.Setup(x => x.Delete(It.IsAny<int>())).Returns(answer);

        var result = _personsController.Delete(_id);
        Assert.NotNull(result);
        Assert.IsType<OkObjectResult>(result.Result);
        _personsRepositoryMock.Verify(x => x.Delete(_id), Moq.Times.AtLeastOnce);
        Assert.IsType<int>(((OkObjectResult)result.Result).Value);
        Assert.Equal(answer, (int)((OkObjectResult)result.Result).Value);
    }

    public static object[][] AddMassive = {
        [new Person() { Id=1, Name = "Денис"}],
        [new Person() { Id=3, Name = "Влад"}],
        [new Person() { Id=5, Name = "Алексей"}],
    };
    [Theory]
    [MemberData(nameof(AddMassive))]
    public void AddTest(Person person)
    {
        _personsRepositoryMock.Setup(x => x.Add(It.IsAny<Person>())).Returns(1);

        var result = _personsController.Add(person);
        Assert.NotNull(result);
        Assert.IsType<OkObjectResult>(result.Result);
        _personsRepositoryMock.Verify(x => x.Add(person), Moq.Times.AtLeastOnce);
        Assert.IsType<int>(((OkObjectResult)result.Result).Value);
        Assert.Equal(1, (int)((OkObjectResult)result.Result).Value);
    }

    public static object[][] UpdateMassive = {
        [new Person() { Id=10, Name = "Денис"}, 1], 
        [new Person() { Id=23, Name = "Влад"}, 0], 
        [new Person() { Id=51, Name = "Алексей"}, 1], 
    };
    [Theory]
    [MemberData(nameof(UpdateMassive))]
    public void UpdateTest(Person person, int answer)
    {
        _personsRepositoryMock.Setup(x => x.Update(It.IsAny<Person>())).Returns(answer);

        var result = _personsController.Update(person);
        Assert.NotNull(result);
        Assert.IsType<OkObjectResult>(result.Result);
        _personsRepositoryMock.Verify(x => x.Update(person), Moq.Times.AtLeastOnce);
        Assert.IsType<int>(((OkObjectResult)result.Result).Value);
        Assert.Equal(answer, (int)((OkObjectResult)result.Result).Value);
    }

}

