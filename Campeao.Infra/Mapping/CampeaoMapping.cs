using Campeao.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Campeao.Infra.Mapping;
public class CampeaoMapping : IEntityTypeConfiguration<NovoCampeao>
{
    public void Configure(EntityTypeBuilder<NovoCampeao> builder)
    {
        builder.ToTable("Campeao");
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Nome).IsRequired();
        builder.Property(x => x.CampeaoPosicao).IsRequired();
        builder.Property(x => x.TipoCampeao).IsRequired();
        builder.Property(x => x.Habilidades).IsRequired();
        builder.Property(x => x.ManaBase).IsRequired();
        builder.Property(x => x.VidaBase).IsRequired();
        builder.Property(x => x.DanoAtaqueBasico).IsRequired();
        builder.Property(x => x.Passiva).IsRequired();
    }
    
}