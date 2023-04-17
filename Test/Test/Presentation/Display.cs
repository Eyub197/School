using System;
using Test;

    public class BearingMenU
    {
        private readonly BearingController _bearingController;

       

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("==== Bearing Menu ====");
                Console.WriteLine("1. View all bearings");
                Console.WriteLine("2. View a specific bearing");
                Console.WriteLine("3. Create a new bearing");
                Console.WriteLine("4. Update an existing bearing");
                Console.WriteLine("5. Delete a bearing");
                Console.WriteLine("0. Back to Main Menu");
                Console.Write("Enter your choice: ");

                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        ViewAllBearings();
                        break;
                    case "2":
                        ViewBearingById();
                        break;
                    case "3":
                        CreateNewBearing();
                        break;
                    case "4":
                        UpdateBearing();
                        break;
                    case "5":
                        DeleteBearing();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }

                Console.WriteLine();
            }
        }

        private void ViewAllBearings()
        {
            var bearings = _bearingController.GetAll();
            foreach (var bearing in bearings)
            {
                Console.WriteLine($"Id: {bearing.Id}, Name: {bearing.Name}, Abec Rating: {bearing.AbecRating}, Material: {bearing.BearingMaterial}");
            }
        }

        private void ViewBearingById()
        {
            Console.Write("Enter bearing id: ");
            var idInput = Console.ReadLine();
            if (int.TryParse(idInput, out int id))
            {
                var bearing = _bearingController.GetById(id);
                if (bearing != null)
                {
                    Console.WriteLine($"Id: {bearing.Id}, Name: {bearing.Name}, Abec Rating: {bearing.AbecRating}, Material: {bearing.BearingMaterial}");
                }
                else
                {
                    Console.WriteLine("Bearing not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

        private void CreateNewBearing()
        {
            Console.Write("Enter brand id: ");
            var brandIdInput = Console.ReadLine();
            if (int.TryParse(brandIdInput, out int brandId))
            {
                Console.Write("Enter bearing name: ");
                var name = Console.ReadLine();
                Console.Write("Enter abec rating: ");
                var abecInput = Console.ReadLine();
                if (int.TryParse(abecInput, out int abecRating))
                {
                    Console.Write("Enter bearing material: ");
                    var material = Console.ReadLine();

                    var newBearing = new Bearing { BrandId = brandId, Name = name, AbecRating = abecRating, BearingMaterial = material };
                    _bearingController.Create(newBearing);

                    Console.WriteLine("New bearing created.");
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

        private void UpdateBearing()
        {
            Console.Write("Enter bearing id: ");
            var idInput = Console.ReadLine();
            if (int.TryParse(idInput, out int id))
            {
                var bearingToUpdate = _bearingController.GetById(id);
                if (bearingToUpdate != null)
                {
                    Console.Write("Enter brand id: ");
                    var brandIdInput = Console.ReadLine();
                    if (int.TryParse(brandIdInput, out int brand))
                    {
                        Console.Write("Enter name: ");
                        var name = Console.ReadLine();
                        Console.Write("Enter ABEC rating: ");
                        var abecRatingInput = Console.ReadLine();
                        if (int.TryParse(abecRatingInput, out int abecRating))
                        {
                            Console.Write("Enter bearing material: ");
                            var bearingMaterial = Console.ReadLine();
                            var updatedBearing = new Bearing
                            {
                                Id = id,
                                BrandId = brand,
                                Name = name,
                                AbecRating = abecRating,
                                BearingMaterial = bearingMaterial
                            };
                            _bearingController.Update(id, updatedBearing);
                            Console.WriteLine("Bearing updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid ABEC rating. Please try again.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid brand id. Please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Bearing not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid id. Please try again.");
            }
        }

        private void DeleteBearing()
        {
            Console.Write("Enter bearing id: ");
            var idInput = Console.ReadLine();
            if (int.TryParse(idInput, out int id))
            {
                var bearingToDelete = _bearingController.GetById(id);
                if (bearingToDelete != null)
                {
                    _bearingController.Delete(id);
                    Console.WriteLine("Bearing deleted successfully.");
                }
                else
                {
                    Console.WriteLine("Bearing not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid id. Please try again.");
            }
        }

    }
