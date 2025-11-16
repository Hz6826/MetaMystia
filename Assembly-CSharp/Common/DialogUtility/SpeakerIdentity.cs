using System;
using System.Runtime.InteropServices;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppSystem;

namespace Common.DialogUtility
{
	// Token: 0x02000342 RID: 834
	[Serializable]
	[StructLayout(2)]
	public struct SpeakerIdentity
	{
		// Token: 0x06006374 RID: 25460 RVA: 0x001EAF64 File Offset: 0x001E9164
		// Note: this type is marked as 'beforefieldinit'.
		static SpeakerIdentity()
		{
			Il2CppClassPointerStore<SpeakerIdentity>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.DialogUtility", "SpeakerIdentity");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<SpeakerIdentity>.NativeClassPtr);
			SpeakerIdentity.NativeFieldInfoPtr_speakerType = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeakerIdentity>.NativeClassPtr, "speakerType");
			SpeakerIdentity.NativeFieldInfoPtr_speakerId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeakerIdentity>.NativeClassPtr, "speakerId");
			SpeakerIdentity.NativeFieldInfoPtr_speakerPortrayalVariationId = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<SpeakerIdentity>.NativeClassPtr, "speakerPortrayalVariationId");
			SpeakerIdentity.NativeMethodInfoPtr__ctor_Public_Void_Identity_Int32_Int32_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeakerIdentity>.NativeClassPtr, 100684219);
			SpeakerIdentity.NativeMethodInfoPtr_op_Implicit_Public_Static_ValueTuple_2_Identity_Int32_SpeakerIdentity_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<SpeakerIdentity>.NativeClassPtr, 100684220);
		}

		// Token: 0x06006375 RID: 25461 RVA: 0x001EAFF8 File Offset: 0x001E91F8
		[CallerCount(0)]
		public unsafe SpeakerIdentity(SpeakerIdentity.Identity speakerType, int speakerId, int speakerPortrayalVariationId)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref speakerType;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speakerId;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref speakerPortrayalVariationId;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(SpeakerIdentity.NativeMethodInfoPtr__ctor_Public_Void_Identity_Int32_Int32_0, ref this, (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006376 RID: 25462 RVA: 0x001EB048 File Offset: 0x001E9248
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 257117, RefRangeEnd = 257122, XrefRangeStart = 257114, XrefRangeEnd = 257117, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe static implicit operator ValueTuple<SpeakerIdentity.Identity, int>(SpeakerIdentity speakerIdentity)
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref speakerIdentity;
			IntPtr intPtr;
			IntPtr pointer = IL2CPP.il2cpp_runtime_invoke(SpeakerIdentity.NativeMethodInfoPtr_op_Implicit_Public_Static_ValueTuple_2_Identity_Int32_SpeakerIdentity_0, 0, (void**)ptr, ref intPtr);
			Il2CppException.RaiseExceptionIfNecessary(intPtr);
			return new ValueTuple<SpeakerIdentity.Identity, int>(pointer);
		}

		// Token: 0x06006377 RID: 25463 RVA: 0x00035BD1 File Offset: 0x00033DD1
		public Object BoxIl2CppObject()
		{
			return new Object(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<SpeakerIdentity>.NativeClassPtr, ref this));
		}

		// Token: 0x040041EC RID: 16876
		private static readonly IntPtr NativeFieldInfoPtr_speakerType;

		// Token: 0x040041ED RID: 16877
		private static readonly IntPtr NativeFieldInfoPtr_speakerId;

		// Token: 0x040041EE RID: 16878
		private static readonly IntPtr NativeFieldInfoPtr_speakerPortrayalVariationId;

		// Token: 0x040041EF RID: 16879
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Identity_Int32_Int32_0;

		// Token: 0x040041F0 RID: 16880
		private static readonly IntPtr NativeMethodInfoPtr_op_Implicit_Public_Static_ValueTuple_2_Identity_Int32_SpeakerIdentity_0;

		// Token: 0x040041F1 RID: 16881
		[FieldOffset(0)]
		public SpeakerIdentity.Identity speakerType;

		// Token: 0x040041F2 RID: 16882
		[FieldOffset(4)]
		public int speakerId;

		// Token: 0x040041F3 RID: 16883
		[FieldOffset(8)]
		public int speakerPortrayalVariationId;

		// Token: 0x02000DFF RID: 3583
		public enum Identity
		{
			// Token: 0x0400A40C RID: 41996
			Self,
			// Token: 0x0400A40D RID: 41997
			Special,
			// Token: 0x0400A40E RID: 41998
			Normal,
			// Token: 0x0400A40F RID: 41999
			Unknown
		}
	}
}
