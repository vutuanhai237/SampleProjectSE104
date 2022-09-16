import static org.junit.jupiter.api.Assertions.*;

import org.junit.jupiter.api.Test;

class TestPer {

	Person p = new Person("Aidan", "Burke");  
	@Test
	public void testGetFullName() {  
        assertEquals("Aidan Burke", p.getFullName());  
    }  
	@Test
    public void testNullsInName() {  
        Person person = new Person(null, "Burke");  
        assertEquals("Burke", person.getFullName()); 
    }  
	
	@Test
	public void testGetFirstName() {
		assertEquals("Aidan", p.getFirstName()); 
	}
	
	@Test
	public void testGetLastName() {
		assertEquals("Burke", p.getLastName()); 
	}
}
