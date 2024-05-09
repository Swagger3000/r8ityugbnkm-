using AutoMapper;
using System;

public class User
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class UserDto
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class UserMapper
{
    private static IMapper _mapper;


    public static Mapper InitializeAutomapper()

    {
        var confiq = new MapperConfiguration(cfg =>
        {
            cfg.CreateMap<User, UserDto>();
        });
        var mapper = new Mapper(confiq);
        return mapper;
    }

}

class Program
{
    static void Main()
    {

        Console.WriteLine("Mapper");
        User emp = new User();

        emp.Age = 11;
        emp.Name = "Namel";
      

        UserDto dto = new UserDto();

        dto.Age = emp.Age;
        dto.Name = emp.Name;
       

        Console.WriteLine("User DTO Name: " + dto.Name);
        Console.WriteLine("User DTO Age: " + dto.Age);

        User user = new User
        {
            Age = 11,
            Name = "bob"
        };

        var mapper = UserMapper.InitializeAutomapper();

        var userDto2 = mapper.Map<User, UserDto>(user);

        Console.WriteLine(userDto2.Age + " " + userDto2.Name + " ");
    }
}