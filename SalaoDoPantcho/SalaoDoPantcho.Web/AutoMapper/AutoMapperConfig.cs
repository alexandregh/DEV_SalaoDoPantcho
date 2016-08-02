using AutoMapper;

namespace SalaoDoPantcho.Web.AutoMapper
{
    public class AutoMapperConfig
    {
        //registrar as classes de configuração criadas para o AutoMapper (Profile)
        public static void Register()
        {
            Mapper.Initialize(
                    mapper =>
                    {
                        mapper.AddProfile<ModelToEntityMapper>();
                        mapper.AddProfile<EntityToModelMapper>();
                    }
                );
        }
    }
}