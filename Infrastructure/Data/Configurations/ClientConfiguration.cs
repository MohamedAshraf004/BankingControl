using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Data.Configurations;

public class ClientConfiguration : IEntityTypeConfiguration<Client>
{
    public void Configure(EntityTypeBuilder<Client> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.FirstName)
            .HasColumnType("nvarchar(59)")
            .IsRequired();
        
        builder.Property(x => x.LastName)
            .HasColumnType("nvarchar(59)")
            .IsRequired();

        builder.Property(x => x.Email)
            .HasColumnType("varchar(250)")
            .IsRequired();
        
        builder.Property(x => x.MobileNumber)
            .HasColumnType("varchar(16)")
            .IsRequired();

        builder.Property(x => x.PersonalKey)
            .HasColumnType("varchar(11)")
            .IsRequired();
        builder.Property(x => x.Gender)           
           .IsRequired();

        builder.ComplexProperty(x => x.Address, addressBuilder =>
        {
            addressBuilder.IsRequired();            
        });


        builder.HasMany(x => x.Accounts)
            .WithOne()
            .HasForeignKey(x=>x.ClientId)
            .IsRequired();
    }
}
