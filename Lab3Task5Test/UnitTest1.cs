namespace Lab3Task5Test;
public class UnitTest1{
    [Fact]
	public void TestProductOf4and5() {
	
		double a = 4; // arrange
		double b = 5;
        double expected = 20;
	
		double actual = Product.Product.Mult(a, b); // act
 
		Assert.Equal(expected, actual); // assert
	}	
	[Fact]
    public void TestProductOf9and3() {
    
		double a = 9; // arrange
        double b = 3;
		double expected = 27;
	
		double actual = Product.Product.Mult(a, b); // act
 
		Assert.Equal(expected, actual); // assert
	} 
}