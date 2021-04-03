using FluentValidation;

namespace Core.CrossCuttingConcerns.Validation
{
    public static class ValidationTool
    {
        //IEntity yerine object yazmamızın nedeni
        //validasyonu dto lar için de kullanma ihtimalimizdir
        public static void Validate(IValidator validator, object entity)
        {
            var result = validator.Validate(entity);
            if (!result.IsValid)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}
