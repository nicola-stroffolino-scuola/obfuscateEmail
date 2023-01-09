namespace Services;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {   
        Assert.Equal("i***@c************i.net", ObfuscationServices.ObfuscateEmail("info@carmelocarmeli.net"));
    }
    [Fact]
    public void Test2()
    {   
        Assert.Equal("i***2@c*************i.net", ObfuscationServices.ObfuscateEmail("info2@carmelo.carmeli.net"));
    }
    [Fact]
    public void Test3()
    {   
        Assert.Equal("i**********e@c*************i.net", ObfuscationServices.ObfuscateEmail("info.vendite@carmelo.carmeli.net"));
    }
    [Fact]
    public void Test4()
    {   
        Assert.Equal("Indirizzo mail non valido", ObfuscationServices.ObfuscateEmail("infocarmelocarmeli.net"));
    }
    [Fact]
    public void Test5()
    {   
        Assert.Equal("Indirizzo mail non valido", ObfuscationServices.ObfuscateEmail("info@carmelocarmelinet"));
    }
    [Fact]
    public void Test6()
    {   
        Assert.Equal("Indirizzo mail non valido", ObfuscationServices.ObfuscateEmail("info@carmelo@carmeli.net"));
    }
    [Fact]
    public void Test7()
    {   
        Assert.Equal("i***@c************i.info", ObfuscationServices.ObfuscateEmail("info@carmelocarmeli.info"));
    }
}