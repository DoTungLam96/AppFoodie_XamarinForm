package md5285ed577435303b2001901e5297f8159;


public class FoodieFab
	extends android.support.design.widget.FloatingActionButton
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("FoodieApp.Droid.FoodieFab, FoodieApp.Android", FoodieFab.class, __md_methods);
	}


	public FoodieFab (android.content.Context p0)
	{
		super (p0);
		if (getClass () == FoodieFab.class)
			mono.android.TypeManager.Activate ("FoodieApp.Droid.FoodieFab, FoodieApp.Android", "Android.Content.Context, Mono.Android", this, new java.lang.Object[] { p0 });
	}


	public FoodieFab (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == FoodieFab.class)
			mono.android.TypeManager.Activate ("FoodieApp.Droid.FoodieFab, FoodieApp.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android", this, new java.lang.Object[] { p0, p1 });
	}


	public FoodieFab (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == FoodieFab.class)
			mono.android.TypeManager.Activate ("FoodieApp.Droid.FoodieFab, FoodieApp.Android", "Android.Content.Context, Mono.Android:Android.Util.IAttributeSet, Mono.Android:System.Int32, mscorlib", this, new java.lang.Object[] { p0, p1, p2 });
	}

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
