// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Gst.Video {

	using System;
	using System.Collections;
	using System.Collections.Generic;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[StructLayout(LayoutKind.Sequential)]
	public partial struct VideoRegionOfInterestMeta : IEquatable<VideoRegionOfInterestMeta> {

		public Gst.Meta Meta;
		public uint RoiType;
		public int Id;
		public int ParentId;
		public uint X;
		public uint Y;
		public uint W;
		public uint H;

		public static Gst.Video.VideoRegionOfInterestMeta Zero = new Gst.Video.VideoRegionOfInterestMeta ();

		public static Gst.Video.VideoRegionOfInterestMeta New(IntPtr raw) {
			if (raw == IntPtr.Zero)
				return Gst.Video.VideoRegionOfInterestMeta.Zero;
			return (Gst.Video.VideoRegionOfInterestMeta) Marshal.PtrToStructure (raw, typeof (Gst.Video.VideoRegionOfInterestMeta));
		}

		[DllImport("libgstvideo-1.0-0.dll", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr gst_video_region_of_interest_meta_get_info();

		public static Gst.MetaInfo Info { 
			get {
				IntPtr raw_ret = gst_video_region_of_interest_meta_get_info();
				Gst.MetaInfo ret = Gst.MetaInfo.New (raw_ret);
				return ret;
			}
		}

		public bool Equals (VideoRegionOfInterestMeta other)
		{
			return true && Meta.Equals (other.Meta) && RoiType.Equals (other.RoiType) && Id.Equals (other.Id) && ParentId.Equals (other.ParentId) && X.Equals (other.X) && Y.Equals (other.Y) && W.Equals (other.W) && H.Equals (other.H);
		}

		public override bool Equals (object other)
		{
			return other is VideoRegionOfInterestMeta && Equals ((VideoRegionOfInterestMeta) other);
		}

		public override int GetHashCode ()
		{
			return this.GetType ().FullName.GetHashCode () ^ Meta.GetHashCode () ^ RoiType.GetHashCode () ^ Id.GetHashCode () ^ ParentId.GetHashCode () ^ X.GetHashCode () ^ Y.GetHashCode () ^ W.GetHashCode () ^ H.GetHashCode ();
		}

		private static GLib.GType GType {
			get { return GLib.GType.Pointer; }
		}
#endregion
	}
}