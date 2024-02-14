using System;
using Autofac;
using RickAndMorty.Business.Abstract;
using RickAndMorty.Business.Concrete;
using RickAndMorty.DataAccess.Abstract;
using RickAndMorty.DataAccess.Concrete.EntityFramework;


namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {

            builder.RegisterType<CharacterManager>().As<ICharacterService>().SingleInstance();
            builder.RegisterType<EfCharacterDal>().As<ICharacterDal>().SingleInstance();

            builder.RegisterType<EpisodeManager>().As<IEpisodeService>().SingleInstance();
            builder.RegisterType<EfEpisodeDal>().As<IEpisodeDal>().SingleInstance();

            builder.RegisterType<EpisodeCharacterManager>().As<IEpisodeCharacterService>().SingleInstance();
            builder.RegisterType<EfEpisodeCharacterDal>().As<IEpisodeCharacterDal>().SingleInstance();
        }
    }
}
