package linear1;
import java.awt.Color;
import java.awt.Graphics;

public interface Drawable {
	public void drawOn(Graphics graphics);
	public void drawOn(Graphics graphics, Color color);
}
