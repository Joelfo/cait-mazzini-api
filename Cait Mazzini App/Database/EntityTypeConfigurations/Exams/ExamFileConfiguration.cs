﻿using CaitMazziniApp.Models.Exams;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CaitMazziniApp.Database.EntityTypeConfigurations.Exams
{
    public class ExamFileConfiguration : IEntityTypeConfiguration<ExamFile>
    {
        public void Configure(EntityTypeBuilder<ExamFile> builder)
        {
            builder.ToTable("exam_files");
            builder.Property(x => x.FilePath).HasColumnName("file_path");
            builder.HasOne(x => x.ComplementaryExam).WithMany(x => x.ExamFiles).HasForeignKey("complementary_exam_id");
        }
    }
}
