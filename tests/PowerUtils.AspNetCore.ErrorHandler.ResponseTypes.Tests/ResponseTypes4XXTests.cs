using PowerUtils.AspNetCore.Attributes;

namespace PowerUtils.AspNetCore.ErrorHandler.ResponseTypes.Tests;

public class ResponseTypes4XXTests
{
    [Fact]
    public void Constructor_Response400ProblemDetailsAttribute()
    {
        // Arrange && Act
        var act = new Response400ProblemDetailsAttribute();


        // Assert
        act.StatusCode.Should()
            .Be(400);

        act.Type.Should()
            .Be(typeof(ProblemDetailsResponse));
    }

    [Fact]
    public void Constructor_Response401ProblemDetailsAttribute()
    {
        // Arrange && Act
        var act = new Response401ProblemDetailsAttribute();


        // Assert
        act.StatusCode.Should()
            .Be(401);

        act.Type.Should()
            .Be(typeof(ProblemDetailsResponse));
    }

    [Fact]
    public void Constructor_Response403ProblemDetailsAttribute()
    {
        // Arrange && Act
        var act = new Response403ProblemDetailsAttribute();


        // Assert
        act.StatusCode.Should()
            .Be(403);

        act.Type.Should()
            .Be(typeof(ProblemDetailsResponse));
    }

    [Fact]
    public void Constructor_Response404ProblemDetailsAttribute()
    {
        // Arrange && Act
        var act = new Response404ProblemDetailsAttribute();


        // Assert
        act.StatusCode.Should()
            .Be(404);

        act.Type.Should()
            .Be(typeof(ProblemDetailsResponse));
    }

    [Fact]
    public void Constructor_Response409ProblemDetailsAttribute()
    {
        // Arrange && Act
        var act = new Response409ProblemDetailsAttribute();


        // Assert
        act.StatusCode.Should()
            .Be(409);

        act.Type.Should()
            .Be(typeof(ProblemDetailsResponse));
    }

    [Fact]
    public void Constructor_Response415ProblemDetailsAttribute()
    {
        // Arrange && Act
        var act = new Response415ProblemDetailsAttribute();


        // Assert
        act.StatusCode.Should()
            .Be(415);

        act.Type.Should()
            .Be(typeof(ProblemDetailsResponse));
    }
}
