package ss;
/*
So, I have 2 methods of thought here, and they're shown in the stack structure. I think that's all I have to do, right,
with the rest of them? I already have DynamicList and DynamicArray in the linear package, so I'll be making new classes
that extend the list and implement the interface, and just return that class. Unless I'm supposed to do something else?

Thank You

Kha Pham

*/

/*
 * SSFactory -- Specialized Structure Factory
 *
 * NOTE WELL -- instructor will help you code this one and even
 * 				code for you if you like (when your classes are ready)
 *				Only purpose of the factory is to give coder "creative freedom"
 *				for this challenge.
 *
 * Replace each "return null;" with your code
 *
 * Purpose is to provide a public gateway for
 * construction of specialized structures.
 *
 * By using this one gateway, everything behind it
 * (specialized structure implementation) is all
 * coder's choice.
 *
 * SEE method below "newFoo" and "newLinkedStack" for examples
 * of how-to do these methods
 *
 * */

import linear.*;

import java.util.Random;

public class StructureFactory {

	//---------------------------------------------------------
	//Generate Stacks (one linked, one arrayed)

	public static <T> StackStructure<T> newLinkedStack() {
		class stackList<T> extends LinkedList<T> implements StackStructure<T> {
			@Override
			public void push(T newElem) {
				addFirst(newElem);
			}

			@Override
			public T pop() {
				return removeFirst();
			}

			@Override
			public T peek() {
				return first();
			}
		}
		return new stackList<T>();
	}

	public static <T> StackStructure<T> newArrayedStack() {
		//See comments in "newLinkedStack" above
		//Note that we need to return an arrayed structure here
		//YOUR CODE HERE (replace "return null;" with your code (per steps 1-2-3 above)

		class stackArray<E> extends DynamicArray<E> implements StackStructure<E> {
			@Override
			public void push(E newElem) {
				addFirst(newElem);
			}

			@Override
			public E pop() {
				return removeFirst();
			}

			@Override
			public E peek() {
				return first();
			}
		}


		return new stackArray();
	}

	//---------------------------------------------------------
	//Generate Queues (one linked, one arrayed)

	public static <E> QueueStructure<E> newLinkedQueue() {
		class queueLinked<E> extends LinkedList<E> implements QueueStructure<E> {


			@Override
			public void enqueue(E newElem) {
				addFirst(newElem);
			}

			@Override
			public E dequeue() {
				return removeLast();
			}

			@Override
			public E peek() {
				return first();
			}

		}
		return new queueLinked<E>();
	}

	public static <T> QueueStructure<T> newArrayedQueue() {
		class queueArray<T> extends DynamicArray<T> implements QueueStructure<T> {


			@Override
			public void enqueue(T newElem) {
				addFirst(newElem);
			}

			@Override
			public T dequeue() {
				return removeLast();
			}

			@Override
			public T peek() {
				return first();
			}

		}
		return new queueArray<T>();
	}

	//---------------------------------------------------------
	//Generate Deques (one linked, one arrayed)

	public static <T> DequeStructure<T> newLinkedDeque() {
		class dequeLinked<T> extends LinkedList<T> implements DequeStructure<T> {

		}
		return new dequeLinked<>();
	}

	public static <T> DequeStructure<T> newArrayedDeque() {
		class dequeArray<T> extends DynamicArray<T> implements DequeStructure<T> {
		}


		return new dequeArray<>();
	}

	//---------------------------------------------------------
	//Generate Bags (one linked, one arrayed)

	public static <T> BagStructure<T> newLinkedBag() {
		class bagLinked<T> extends LinkedList<T> implements BagStructure<T> {

			@Override
			public T any() {
				Random random = new Random();
				int ran = random.nextInt(size());
				return (T) toJavaList().get(random.nextInt(size()));
			}
		}
		return new bagLinked<T>();
	}

	public static <T> BagStructure<T> newArrayedBag() {
		class bagArray<T> extends LinkedList<T> implements BagStructure<T> {

			@Override
			public T any() {
				Random random = new Random();
				return (T) toJavaList().get(random.nextInt(size()));
			}
		}
		return new bagArray<T>();
	}

	//I was trying to do it with abstract classes, in a way like this, but it kept returning an error
	/*abstract static class stackFlex<E> implements StackStructure<E>, DynamicList<E>, IterableStructure{
		@Override
		public void push(E newElem) {
			addFirst(newElem);
		}

		@Override
		public E pop() {
			return removeFirst();
		}

		@Override
		public E peek() {
			return first();
		}
	}
	*/
}












