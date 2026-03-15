namespace TheWindCorner.Services.Mapping
{
    using AutoMapper;


    public interface IHaveCustomMappings
    {
        void CreateMappings(IProfileExpression configuration);
    }
}
