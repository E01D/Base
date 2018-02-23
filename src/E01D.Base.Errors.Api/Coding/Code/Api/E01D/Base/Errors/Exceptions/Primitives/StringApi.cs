using Root.Coding.Code.Api.E01D.Base.Errors.Exceptions.Primitives.Strings;

namespace Root.Coding.Code.Api.E01D.Base.Errors.Exceptions.Primitives
{
    public class StringApi
    {
        public ValidationApi Validation { get; set; } = new ValidationApi();

        public RequirementApi Requirements { get; set; } = new RequirementApi();
    }
}
