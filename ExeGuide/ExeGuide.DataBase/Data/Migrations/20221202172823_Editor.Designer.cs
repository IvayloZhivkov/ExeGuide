﻿// <auto-generated />
using System;
using ExeGuide.DataBase.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ExeGuide.DataBase.Data.Migrations
{
    [DbContext(typeof(ExeGuideDbContext))]
    [Migration("20221202172823_Editor")]
    partial class Editor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ExeGuide.Data.Entities.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Equipments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Machine"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Dumbbells"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Barbell"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Kettlebell"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Cables"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Band"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Bodyweight"
                        });
                });

            modelBuilder.Entity("ExeGuide.Data.Entities.Exercise", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("nvarchar(1000)");

                    b.Property<int>("EquipmentId")
                        .HasColumnType("int");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MainCategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("SubCategoryId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EquipmentId");

                    b.HasIndex("MainCategoryId");

                    b.HasIndex("SubCategoryId");

                    b.ToTable("Exercises");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Grasp the handles with a full grip, your thumb circled around the handle. Maintain a neutral wrist position with your wrists in line with your forearms. Exhale and push outward until your arms are fully extended (don't lock the elbows). Keep your head steady against the back support during this movement and your neck still. You should feel resistance against the horizontal push. Pause briefly at full extension. Bend your elbows and return to the starting position, breathing in during this recovery.",
                            EquipmentId = 1,
                            ImageUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse3.mm.bing.net%2Fth%3Fid%3DOIP.k8Rg6S8G76qWwlN3b5AtDAHaD7%26pid%3DApi&f=1&ipt=4035c303d0f607c9b4a2ea90074597fdf9e7ceff0e3d2979217ac4a47f9bb275&ipo=images",
                            MainCategoryId = 1,
                            Name = "Chest Press (Machine)",
                            SubCategoryId = 2
                        },
                        new
                        {
                            Id = 2,
                            Description = "Adjust the machine seat to a comfortable height. Set the handles, so they are roughly at shoulder height. Sit upright in the chair. Ensure that you are erect but comfortable with your back against the back pad. Keep your feet flat on the floor and shoulder-width apart. Your knees should be bent at a 90-degree angle. Grab and hold the handles with a solid pronated or neutral grip. Your elbows should be bent and pointing towards the floor. Inhale and press the handle overhead straight to the ceiling. Hold this position at the top without locking out your elbows. Exhale and slowly bring your arms down without letting it go to the starting position. This is one rep. Complete as many repetitions as you can fit in a set.",
                            EquipmentId = 1,
                            ImageUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse3.mm.bing.net%2Fth%3Fid%3DOIP.0e2UWyilV3gMvK-i13y3DAAAAA%26pid%3DApi&f=1&ipt=607becc9e2f63842d62296fe5ddf0e51b9841ae33b8126af904581b8995b60d8&ipo=images",
                            MainCategoryId = 2,
                            Name = "Shoulder Press (Machine)",
                            SubCategoryId = 4
                        },
                        new
                        {
                            Id = 3,
                            Description = "Load some weight onto a barbell. For more convenience, use a fixed bar. Grab the bar with a narrow underhand grip so that your elbows are in front of your body rather than by your sides. Curl the weight toward your chest by moving your forearms toward your biceps. Keep lifting until the undersides of your forearms press right up against your biceps. Hold the contraction for a moment and then lower the bar under control until your elbows are extended.",
                            EquipmentId = 3,
                            ImageUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse1.mm.bing.net%2Fth%3Fid%3DOIP.jsjvVwiOzjntzwG0SzY-2AHaEN%26pid%3DApi&f=1&ipt=a5d54b43b5b0ef0915eca5fff586af37cd0c6cd0ae2f54a715dcc7a0bb20a3d9&ipo=images",
                            MainCategoryId = 3,
                            Name = "Biceps Curl Narrow Grip (Barbell)",
                            SubCategoryId = 7
                        },
                        new
                        {
                            Id = 4,
                            Description = "Make sure that the seat’s height is correctly adjusted to your body so that your shoulders rest back comfortably on the padding. Select the weight load that you want to use and insert the pin into the corresponding hole. (If you haven’t used this type of machine before, we recommend starting at a low weight so that you can test your comfort zone a bit.) Flex your core, push against the padded lever, and bend forward at the waist. Your hips should stay in the seat at all times. Try to move in a slow, controlled manner. You won’t gain anything from violently trying to yank up a heavier weight using improper form. Breathe in as you come back to the starting position and finish the movement. The repetition is complete when your body returns to an upright position. From there, repeat as many reps as your training plan allows.",
                            EquipmentId = 1,
                            ImageUrl = "https://external-content.duckduckgo.com/iu/?u=https%3A%2F%2Ftse3.mm.bing.net%2Fth%3Fid%3DOIP.WWl864s7p73ahJeqJ4HpqwHaEO%26pid%3DApi&f=1&ipt=485310cf72e25630942cbf1878f9b107e6bd6df615ebab717a56d6f44bcda200&ipo=images",
                            MainCategoryId = 4,
                            Name = "Abdominal Crunch (Machine)",
                            SubCategoryId = 14
                        });
                });

            modelBuilder.Entity("ExeGuide.Data.Entities.MainCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("MainCategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("MainCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MainCategoryName = "Chest"
                        },
                        new
                        {
                            Id = 2,
                            MainCategoryName = "Shoulders"
                        },
                        new
                        {
                            Id = 3,
                            MainCategoryName = "Arms"
                        },
                        new
                        {
                            Id = 4,
                            MainCategoryName = "Abdominal"
                        },
                        new
                        {
                            Id = 5,
                            MainCategoryName = "Back"
                        },
                        new
                        {
                            Id = 6,
                            MainCategoryName = "Legs"
                        });
                });

            modelBuilder.Entity("ExeGuide.Data.Entities.SubCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("SubCategoryName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("SubCategories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            SubCategoryName = "Upper Chest"
                        },
                        new
                        {
                            Id = 2,
                            SubCategoryName = "Middle Chest"
                        },
                        new
                        {
                            Id = 3,
                            SubCategoryName = "Lower Chest"
                        },
                        new
                        {
                            Id = 4,
                            SubCategoryName = "Front Deltoid (Shoulder)"
                        },
                        new
                        {
                            Id = 5,
                            SubCategoryName = "Middle Deltoid (Shoulder)"
                        },
                        new
                        {
                            Id = 6,
                            SubCategoryName = "Rear  Deltoid (Shoulder)"
                        },
                        new
                        {
                            Id = 7,
                            SubCategoryName = "Long Head (Biceps)"
                        },
                        new
                        {
                            Id = 8,
                            SubCategoryName = "Short Head"
                        },
                        new
                        {
                            Id = 9,
                            SubCategoryName = "Brachialis"
                        },
                        new
                        {
                            Id = 10,
                            SubCategoryName = "Long Head (Triceps)"
                        },
                        new
                        {
                            Id = 11,
                            SubCategoryName = "Medial Head"
                        },
                        new
                        {
                            Id = 12,
                            SubCategoryName = "Lateral Head"
                        },
                        new
                        {
                            Id = 13,
                            SubCategoryName = "Medial Head"
                        },
                        new
                        {
                            Id = 14,
                            SubCategoryName = "Upper Abdominal"
                        },
                        new
                        {
                            Id = 15,
                            SubCategoryName = "Lower Abdominal"
                        },
                        new
                        {
                            Id = 16,
                            SubCategoryName = "Obliques"
                        },
                        new
                        {
                            Id = 17,
                            SubCategoryName = "Traps"
                        },
                        new
                        {
                            Id = 18,
                            SubCategoryName = "Infraspinatus"
                        },
                        new
                        {
                            Id = 19,
                            SubCategoryName = "Lats"
                        },
                        new
                        {
                            Id = 20,
                            SubCategoryName = "Lower Back"
                        },
                        new
                        {
                            Id = 21,
                            SubCategoryName = "Glutes"
                        },
                        new
                        {
                            Id = 22,
                            SubCategoryName = "Vastus Lateralis (Outer Quad)"
                        },
                        new
                        {
                            Id = 23,
                            SubCategoryName = "Rectus Femoris (Middle Quad)"
                        },
                        new
                        {
                            Id = 24,
                            SubCategoryName = "Vastus Medialis (Inner Quad)"
                        },
                        new
                        {
                            Id = 25,
                            SubCategoryName = "Semitendinosus (Inner Hamstring)"
                        },
                        new
                        {
                            Id = 26,
                            SubCategoryName = "Biceps Femoris (Middle Hamstring)"
                        },
                        new
                        {
                            Id = 27,
                            SubCategoryName = "Semimembranosus (Outer Hamstring)"
                        },
                        new
                        {
                            Id = 28,
                            SubCategoryName = "Soleus (Upper Calf)"
                        },
                        new
                        {
                            Id = 29,
                            SubCategoryName = "Gastrocnemius (Lower Calf)"
                        },
                        new
                        {
                            Id = 30,
                            SubCategoryName = "Brachiordinalis (Forearm)"
                        },
                        new
                        {
                            Id = 31,
                            SubCategoryName = "Flexors (Forearm)"
                        },
                        new
                        {
                            Id = 32,
                            SubCategoryName = "Extensors (Forearm)"
                        });
                });

            modelBuilder.Entity("ExeGuide.Data.Entities.TrainingUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "bcb4f072-ecca-43c9-ab26-c060c6f364e4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3a56347e-2a6a-4585-9272-cf85dfe03069",
                            Email = "editor@traininghelper.com",
                            EmailConfirmed = false,
                            FirstName = "Great",
                            LastName = "Editor",
                            LockoutEnabled = false,
                            NormalizedEmail = "editor@traininghelper.com",
                            NormalizedUserName = "editor@traininghelper.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEE1LuqNTpUz1neY81FWJU72OSdzN3rzdRBBwGs3twJ+1HmwnKNK/stdLa3T49Xtgpg==",
                            PhoneNumberConfirmed = false,
                            TwoFactorEnabled = false,
                            UserName = "editor@traininghelper.com"
                        });
                });

            modelBuilder.Entity("ExeGuide.Data.Entities.TrainingUsersExercise", b =>
                {
                    b.Property<int>("ExerciseId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("ExerciseId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("TrainingUsersExercises");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ExeGuide.Data.Entities.Exercise", b =>
                {
                    b.HasOne("ExeGuide.Data.Entities.Equipment", "Equipment")
                        .WithMany("Exercises")
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ExeGuide.Data.Entities.MainCategory", "MainCategory")
                        .WithMany("Exercises")
                        .HasForeignKey("MainCategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("ExeGuide.Data.Entities.SubCategory", "SubCategory")
                        .WithMany("Exercises")
                        .HasForeignKey("SubCategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Equipment");

                    b.Navigation("MainCategory");

                    b.Navigation("SubCategory");
                });

            modelBuilder.Entity("ExeGuide.Data.Entities.TrainingUsersExercise", b =>
                {
                    b.HasOne("ExeGuide.Data.Entities.Exercise", "Exercise")
                        .WithMany("TrainingUsersExercises")
                        .HasForeignKey("ExerciseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExeGuide.Data.Entities.TrainingUser", "TrainingUser")
                        .WithMany("TrainingUsersExercises")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");

                    b.Navigation("TrainingUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("ExeGuide.Data.Entities.TrainingUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("ExeGuide.Data.Entities.TrainingUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ExeGuide.Data.Entities.TrainingUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("ExeGuide.Data.Entities.TrainingUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ExeGuide.Data.Entities.Equipment", b =>
                {
                    b.Navigation("Exercises");
                });

            modelBuilder.Entity("ExeGuide.Data.Entities.Exercise", b =>
                {
                    b.Navigation("TrainingUsersExercises");
                });

            modelBuilder.Entity("ExeGuide.Data.Entities.MainCategory", b =>
                {
                    b.Navigation("Exercises");
                });

            modelBuilder.Entity("ExeGuide.Data.Entities.SubCategory", b =>
                {
                    b.Navigation("Exercises");
                });

            modelBuilder.Entity("ExeGuide.Data.Entities.TrainingUser", b =>
                {
                    b.Navigation("TrainingUsersExercises");
                });
#pragma warning restore 612, 618
        }
    }
}
