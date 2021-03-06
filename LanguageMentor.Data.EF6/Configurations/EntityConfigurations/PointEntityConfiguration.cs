﻿using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using LanguageMentor.Data.Entities;

namespace LanguageMentor.Data.EF6.Configurations.EntityConfigurations
{
    public sealed class PointEntityConfiguration : EntityTypeConfiguration<PointEntity>
    {
        public PointEntityConfiguration()
        {
            ToTable("points");

            Property(c => c.PointId).HasColumnName("point_id").IsRequired();
            Property(c => c.PointText).HasColumnName("point_text").IsRequired().HasMaxLength(256);
            Property(c => c.ExerciseId).HasColumnName("exercise_id").IsRequired();
            Property(c => c.IsMultipleChoices).HasColumnName("is_multiple_choices").IsRequired();

            HasKey(c => c.PointId);
            Property(c => c.PointId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            HasRequired(point => point.Exercise)
                .WithMany(exercise => exercise.Points)
                .HasForeignKey(point => point.ExerciseId)
                .WillCascadeOnDelete();
        }
    }
}
