using Microsoft.AspNetCore.Mvc;
using HotelManagement.DAL.Repositories;
using HotelManagement.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;


namespace HotelManagement.Controllers
{
    /// <summary>
    /// ReviewsController handles the management of room and food reviews.
    /// TODO Consider making the review more generic and reusable for both rooms and food.
    /// </summary>
    public class ReviewsController : Controller
    {
        private readonly ReviewRepository _reviewRepository;

        public ReviewsController(ReviewRepository reviewRepository)
        {
            _reviewRepository = reviewRepository;
        }

        /// <summary>
		/// AddRoomReview allows a user to submit a review for a room they have booked.
		/// </summary>
		/// <param name="RoomId"> The ID of the room being reviewed. </param>
		/// <param name="Rating"> The rating given by the user (1-5). </param>
		/// <param name="Comment"> The comment provided by the user. </param>
		/// <returns> A redirect to the BookingRoomDetails view with a success message. </returns>
		[HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public IActionResult AddRoomReview(Guid RoomId, int Rating, string Comment)
        {
            // Review actions are here for now, maybe create a separate ReviewsController later
            // if we want to manage reviews separately and delete them, etc.
            var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

            var review = new Review
            {
                Id = Guid.NewGuid(),
                RoomId = RoomId,
                ApplicationUserId = userId,
                Rating = Rating,
                Comment = Comment,
                ReviewDate = DateTime.UtcNow
            };

            _reviewRepository.Create(review);

            TempData["Success"] = "Review submitted successfully.";

            return Json(new { success = true, message = "Review submitted successfully." });
        }

        /// <summary>
        /// EditRoomReview allows a user to edit their existing review for a room.
        /// Each user can post only one review per room, so this updates the existing review.
        /// </summary>
        /// <param name="ReviewId"> The ID of the review being edited. </param>
        /// <param name="Rating"> The new rating given by the user (1-5). </param>
        /// <param name="Comment"> The new comment provided by the user. </param>
        /// /// <returns> A redirect to the BookingRoomDetails view with a success message. </returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public IActionResult EditRoomReview(Guid ReviewId, int Rating, string Comment)
        {
            var review = _reviewRepository.GetById(ReviewId);
            if (review == null || review.ApplicationUserId != Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)))
                return NotFound();

            review.Rating = Rating;
            review.Comment = Comment;
            review.ReviewDate = DateTime.UtcNow;

            _reviewRepository.Update(review);

            TempData["Success"] = "Review updated successfully.";

            return Json(new { success = true, message = "Review updated successfully." });
        }

        /// <summary>
        /// AddFoodReview allows a user to submit a review for a food they have booked.
        /// </summary>
        /// <param name="FoodId"> The ID of the Food being reviewed. </param>
        /// <param name="Rating"> The rating given by the user (1-5). </param>
        /// <param name="Comment"> The comment provided by the user. </param>
        /// <!----> <returns> A JSON response indicating success or failure. </returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public IActionResult AddFoodReview(Guid FoodId, int Rating, string Comment)
        {
            // Review actions are here for now, maybe create a separate ReviewsController later
            // if we want to manage reviews separately and delete them, etc.
            var userId = Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier));

            var review = new Review
            {
                Id = Guid.NewGuid(),
                FoodId = FoodId,
                ApplicationUserId = userId,
                Rating = Rating,
                Comment = Comment,
                ReviewDate = DateTime.UtcNow
            };

            _reviewRepository.Create(review);

            TempData["Success"] = "Review submitted successfully.";

            return Json(new { success = true, message = "Review submitted successfully." });
        }

        /// <summary>
        /// EditFoodReview allows a user to edit their existing review for a food.
        /// Each user can post only one review per food, so this updates the existing review.
        /// </summary>
        /// <param name="ReviewId"> The ID of the review being edited. </param>
        /// <param name="Rating"> The new rating given by the user (1-10). </param>
        /// <param name="Comment"> The new comment provided by the user. </param>
        /// <returns> A JSON response indicating success or failure. </returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public IActionResult EditFoodReview(Guid ReviewId, int Rating, string Comment)
        {
            var review = _reviewRepository.GetById(ReviewId);
            if (review == null || review.ApplicationUserId != Guid.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)))
                return NotFound();

            review.Rating = Rating;
            review.Comment = Comment;
            review.ReviewDate = DateTime.UtcNow;

            _reviewRepository.Update(review);

            TempData["Success"] = "Review updated successfully.";

            return Json(new { success = true, message = "Review updated successfully." });
        }

        // I think this one is currently used, maybe remove the other AddFoodReview and EditFoodReview methods
        /// <summary>
        /// SubmitFoodReview allows a user to submit a review for food.
        /// If the user has already submitted a review for the same food, it updates the existing review.
        /// /// </summary>
        /// <param name="review"> The review object containing food ID, rating, comment, and user ID. </param>
        /// /// <returns> A redirect to the FoodMenu view with a success message. </returns>
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult SubmitFoodReview(Review review)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            if (userId == null) return Unauthorized();

            var foodId = review.FoodId ?? Guid.Empty;

            review.ApplicationUserId = Guid.Parse(userId);
            review.ReviewDate = DateTime.Now;

            Review? existingReview = _reviewRepository.GetByFoodIdAndUserId(foodId, review.ApplicationUserId);
            if (existingReview != null)
            {
                // Update existing review
                existingReview.Rating = review.Rating;
                existingReview.Comment = review.Comment;
                existingReview.ReviewDate = DateTime.Now;
                _reviewRepository.Update(existingReview);
            }
            else
            {
                // Create new review
                _reviewRepository.Create(review);
            }
            TempData["Success"] = "Review submitted successfully.";
            return RedirectToAction(controllerName: "Foods", actionName: "FoodMenu");
        }
    }
}
