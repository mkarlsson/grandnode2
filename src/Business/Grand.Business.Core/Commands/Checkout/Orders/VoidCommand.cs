﻿using Grand.Domain.Payments;
using MediatR;

namespace Grand.Business.Core.Commands.Checkout.Orders;

public class VoidCommand : IRequest<IList<string>>
{
    public PaymentTransaction PaymentTransaction { get; set; }
}