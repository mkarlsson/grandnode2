﻿using Grand.Domain.Catalog;
using Grand.Web.Models.Catalog;
using MediatR;

namespace Grand.Web.Events;

public class ProductReviewEvent : INotification
{
    public ProductReviewEvent(Product product, AddProductReviewModel productReview)
    {
        Product = product;
        ProductReview = productReview;
    }

    public Product Product { get; private set; }
    public AddProductReviewModel ProductReview { get; private set; }
}