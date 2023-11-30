namespace ClassWork.Lesson10;

public class Coupon
{
    public double DiscountAmount { get; }

    public Coupon(double discountAmount)
    {
        if (discountAmount is <= 0 or >= 100)
        {
            throw new ArgumentException();
        }
        DiscountAmount = discountAmount;
    }

    public static Coupon operator +(Coupon coupon1, Coupon coupon2)
    {
        return new Coupon(coupon1.DiscountAmount + coupon2.DiscountAmount * 0.5);
    }
}