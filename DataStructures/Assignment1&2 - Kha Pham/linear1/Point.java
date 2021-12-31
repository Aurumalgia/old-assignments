package linear1;
import java.awt.Color;
import java.awt.Graphics;

public class Point implements Drawable {

	private int x;
	private int y;
	
	public Point(int x, int y) {
		super();
		this.x = x;
		this.y = y;
	}
	
	public int getX() {
		return x;
	}
	
	public void setX(int x) {
		this.x = x;
	}
	
	public int getY() {
		return y;
	}
	
	public void setY(int y) {
		this.y = y;
	}
	
	@Override
	public void drawOn(Graphics graphics) {
		this.drawOn(graphics, Color.blue);
	}
	
	@Override
	public void drawOn(Graphics graphics, Color color) {
		Frame f = this.getBoundary();
		f.growByAmount(5);
		graphics.setColor(color);
		int 
			width = f.getHeight(),		
			height = f.getHeight();
		graphics.drawOval(f.getLeft(), f.getTop(), width, height);
		graphics.fillOval(f.getLeft(), f.getTop(), width, height);
	}

	private Frame getBoundary() {
		//Return frame at point (frame will have width & height of zero)		
		int x, y;
		x = this.x;
		y = this.y;
		return new Frame(x, y, x, y);
	}
	
	@Override
	public String toString() {
		//(10, 5)
		return "(" + this.x + ", " + this.y + ")";
	}	
	
}
