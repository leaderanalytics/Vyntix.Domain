namespace LeaderAnalytics.Vyntix.Domain.Components;

public static class ErrorMessage
{
    public const string DuplicateEntity = "Duplicate entity.  Make sure the fields that identity this entity are unique.  These fields often include NativeID, Name, or Symbol.  For vintages, every combination of Native ID, Data Provider ID, and Vintage Date must be unique.";

    public static string NoDataPermissionErrorMessage(IUser user, string dataProviderName, DataPermission permission)
    {
        return $"User {user.Name}, with ID {user.ID} does not have permission \"{permission.ToString()}\" which is required to perform this action for Data Provider {dataProviderName}.";
    }

    public static string ObjectNotFoundErrorMessage(Type typeofObject, string identifier)
    {
        return $"An object of type {typeofObject.Name} with identifier {identifier} was not found.";
    }
}
