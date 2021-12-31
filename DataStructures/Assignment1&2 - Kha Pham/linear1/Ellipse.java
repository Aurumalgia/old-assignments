package linear1;
import java.awt.Color;
import java.awt.Graphics;

public class Ellipse {

	//-------------------------------------------
	//Instance Variables

	/*
		"a" is the ellipse semi-major axis
		"b" is the ellipse semi-minor axis*/	

	private Point center;
	private int a;
	private int b;
	
	//-------------------------------------------
	//Static factory methods

	public static Ellipse fromRadius(Point center, int r) {
		//Circle case set axis both to r
		return fromCenterAB(center, r, r); 
	}
	
	public static Ellipse fromCenterAB(Point center, int a, int b) {
		return new Ellipse(center, a, b);
	}	
	
	//-------------------------------------------
	//Constructors

	private Ellipse(Point cc, int a, int b) {
		//Set our point center to parameter
		//Set our ivar to parameter		
		super();
		this.center = cc;
		this.a = a;
		this.b = b;
	}
	
	private Ellipse() {
		//No args constructor
		//Set our (this) center to a point with x=0, y=0
		//Set our (this) a to 0		
		//Set our (this) b to 0		
		this(new Point(0, 0), 0, 0);
	}	
	
	//-------------------------------------------
	//Instance Methods -- Special Behaviors

	public void drawOn(Graphics graphics, Color color) {
		/*
		Send the message "setColor" to "graphics" with param "color" 
		Send the message drawOval to "graphics"
		Send the message fillOval to "graphics"
		Each has the same four params:
		 	left
		 	top
		 	width
		 	height
		 left is the left edge of the circle
		 top is the top edge of the circel
		 width is the width of the boundary that bounds this circle
		 height is the height of the boundary that bounds this circle		 
		 hint: The key word in above description starts with the letter "b"
		 Side note (fyi only): The bounding width will equal
		  						the bounding height (for circle)
		 */
		Frame f = this.getBoundary();
		graphics.setColor(color);
		int 
			width = f.getWidth(),		
			height = f.getHeight();
		graphics.drawOval(f.getLeft(), f.getTop(), width, height);
		graphics.fillOval(f.getLeft(), f.getTop(), width, height);
	}

	//-------------------------------------------
	//Instance Methods -- Special Getters And Setters

	public Frame getBoundary() {
		/*Return a Frame object that defines the boundary of this ellipse
		Algorithm:
			left = center x - a
			top = center y - b
			right = center x + a
			bottom = center y + b
		*/		
		int cx, cy, aa, bb;
		cx = this.center.getX();
		cy = this.center.getY();
		aa = this.a;
		bb = this.b;
		return new Frame(cx - aa, cy - bb, cx + aa, cy + bb);
	}

	//============================================================
	//Code below this line is DONE
	
	@Override
	public String toString() {
		//THIS CODE IS DONE		
		return "Ellipse: " + "Center= " + 
				this.center.toString() + " -- Semi-Major= " + 
				this.a + " Semi-Minor= " + this.b
				+ " -- " + getBoundary().basicToString();
	}

	@Override
	public int hashCode() {
		//THIS CODE IS DONE
		//Return hash code that identifies object		
		final int prime = 31;
		int result = 1;
		result = prime * result + a;
		result = prime * result + b;
		result = prime * result + ((center == null) ? 0 : center.hashCode());
		return result;
	}

	@Override
	public boolean equals(Object obj) {
		//THIS CODE IS DONE
		//Return true if we equal param aOther		
		if (this == obj)
			return true;
		if (obj == null)
			return false;
		if (getClass() != obj.getClass())
			return false;
		Ellipse other = (Ellipse) obj;
		if (this.a != other.a)
			return false;
		if (this.b != other.b)
			return false;
		if (this.center == null) {
			if (other.center != null)
				return false;
		} else if (!center.equals(other.center))
			return false;
		return true;
	}
		
}