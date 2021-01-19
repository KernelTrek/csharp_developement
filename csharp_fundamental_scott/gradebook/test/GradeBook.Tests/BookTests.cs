using System;
using Xunit;

namespace GradeBook.Tests
{

    // 클래스 별로 테스트 파일이 별도로 있어야 한다.
    // 테스트는 3개 섹션으로 보통 나누며
    // 예상값 및 변수 선언, 실제 함수 동작 , 결과 비교 로 나누게 된다. 
    public class BookTests
    {
        [Fact]
        public void Pass_Test()
        {
            // arrange : 변수를 정의하고, 예상 결과 변수를 정의한다.
            var book = new Book("");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            // act : 실제 함수를 돌려 보는 것
            var result = book.GetStatistics();

            // assert : 값을 비교 
            Assert.Equal(85.6, result.Average, 1);
            Assert.Equal(90.5, result.High, 1);
            Assert.Equal(77.3, result.Low, 1);


        }
    }
}
