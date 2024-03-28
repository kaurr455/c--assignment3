public class Person : BaseClass
{
    // Properties for FirstName and LastName
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Constructor with two string parameters having default values
    public Person(string firstName = "", string lastName = "")
    {
        FirstName = firstName;
        LastName = lastName;
    }

    // Overridden IsValidated method
    public override bool IsValidated()
    {
        // Null-coalescing assignment to ensure non-null strings
        FirstName = FirstName ?? "";
        LastName = LastName ?? "";

        // Validation logic
        return FirstName.Length > 0 && LastName.Length > 0;
    }
}