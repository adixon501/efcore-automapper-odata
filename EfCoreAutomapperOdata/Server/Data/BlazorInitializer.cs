using EfCoreAutomapperOdata.Server.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EfCoreAutomapperOdata.Server.Data
{
    public static class BlazorInitializer
    {
        public static void Initialize(BlazorContext context)
        {
            context.Database.EnsureCreated();

            var instructor1 = new Instructor { Name = "Mr. Smith" };
            var instructor2 = new Instructor { Name = "Mrs. Appleberry" };

            var course1 = new Course { Name = "Science" };
            var course2 = new Course { Name = "Math" };

            if (!context.Instructor.Any())
            {
                instructor1 = context.Instructor.Add(instructor1).Entity;
                instructor2 = context.Instructor.Add(instructor2).Entity;

                context.SaveChanges();

                if (!context.Course.Any())
                {
                    course1.Instructor = instructor1;
                    course2.Instructor = instructor2;

                    course1 = context.Course.Add(course1).Entity;
                    course2 = context.Course.Add(course2).Entity;

                    context.SaveChanges();

                    var students = new List<Student> {
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Parker Hutchings" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Shanay Hamilton" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Frankie Drew" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Mayur Lister" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Dennis Clemons" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Briony Stevens" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Cherise Delarosa" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Avni Barker" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Sumayya Leal" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Corben Huber" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Edgar Haley" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Vihaan O'Moore" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Ilyas Andersen" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Sandra Vinson" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Kobi Kemp" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Dixie Zhang" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Sorcha Beattie" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Eisa Naylor" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Makenzie Dickinson" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Cerys Hines" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Quinn Lott" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Bluebell Bate" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Kendall Goddard" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Firat Page" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Robert Bradshaw" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Destiny Denton" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Cecil Spooner" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Tye Hirst" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Tomi Skinner" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Brennan Giles" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Iosif Crosby" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Ayush Lewis" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Manraj Foley" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Dora Davies" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Sophia Cruz" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Emaan Carson" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Borys Hess" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Kieren Stanton" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Ariella Pierce" },
                        new Student { Courses = new List<CourseStudent> { new CourseStudent { CourseId = course1.Id }, new CourseStudent { CourseId = course2.Id }}, Name = "Kaiden Hayward" }
                    };

                    if (!context.Student.Any())
                    {
                        context.Student.AddRange(students);

                        context.SaveChanges();

                        students = context.Student.ToList();

                        var friendsList = new List<FriendsRel>();
                        var friendGroup = students.Take(5).Skip(0).ToList();

                        friendGroup.ForEach(s => {
                            friendsList.AddRange(friendGroup.Select(f => {
                                if (s.Id != f.Id)
                                    return new FriendsRel { StudentId = s.Id, FriendId = f.Id };
                                else
                                    return null;
                                }));
                        });

                        friendGroup = students.Take(5).Skip(5).ToList();

                        friendGroup.ForEach(s => {
                            friendsList.AddRange(friendGroup.Select(f => {
                                if (s.Id != f.Id)
                                    return new FriendsRel { StudentId = s.Id, FriendId = f.Id };
                                else
                                    return null;
                            }));
                        });

                        friendGroup = students.Take(5).Skip(10).ToList();

                        friendGroup.ForEach(s => {
                            friendsList.AddRange(friendGroup.Select(f => {
                                if (s.Id != f.Id)
                                    return new FriendsRel { StudentId = s.Id, FriendId = f.Id };
                                else
                                    return null;
                            }));
                        });

                        friendGroup = students.Take(5).Skip(15).ToList();

                        friendGroup.ForEach(s => {
                            friendsList.AddRange(friendGroup.Select(f => {
                                if (s.Id != f.Id)
                                    return new FriendsRel { StudentId = s.Id, FriendId = f.Id };
                                else
                                    return null;
                            }));
                        });

                        friendGroup = students.Take(5).Skip(20).ToList();

                        friendGroup.ForEach(s => {
                            friendsList.AddRange(friendGroup.Select(f => {
                                if (s.Id != f.Id)
                                    return new FriendsRel { StudentId = s.Id, FriendId = f.Id };
                                else
                                    return null;
                            }));
                        });

                        friendGroup = students.Take(5).Skip(25).ToList();

                        friendGroup.ForEach(s => {
                            friendsList.AddRange(friendGroup.Select(f => {
                                if (s.Id != f.Id)
                                    return new FriendsRel { StudentId = s.Id, FriendId = f.Id };
                                else
                                    return null;
                            }));
                        });

                        friendGroup = students.Take(5).Skip(30).ToList();

                        friendGroup.ForEach(s => {
                            friendsList.AddRange(friendGroup.Select(f => {
                                if (s.Id != f.Id)
                                    return new FriendsRel { StudentId = s.Id, FriendId = f.Id };
                                else
                                    return null;
                            }));
                        });

                        friendGroup = students.Take(5).Skip(35).ToList();

                        friendGroup.ForEach(s => {
                            friendsList.AddRange(friendGroup.Select(f => {
                                if (s.Id != f.Id)
                                    return new FriendsRel { StudentId = s.Id, FriendId = f.Id };
                                else
                                    return null;
                            }));
                        });

                        context.FriendsRel.AddRange(friendsList);

                        context.SaveChanges();
                    }
                }
            }
        }
    }
}
