using System;
using GameData.RunTime.Common;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002C5 RID: 709
	public class CGProfile : ScriptableObject
	{
		// Token: 0x06005842 RID: 22594 RVA: 0x001C8054 File Offset: 0x001C6254
		// Note: this type is marked as 'beforefieldinit'.
		static CGProfile()
		{
			Il2CppClassPointerStore<CGProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "CGProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CGProfile>.NativeClassPtr);
			CGProfile.NativeFieldInfoPtr_cgPictures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CGProfile>.NativeClassPtr, "cgPictures");
			CGProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<CGProfile>.NativeClassPtr, 100681244);
		}

		// Token: 0x06005843 RID: 22595 RVA: 0x001C80AC File Offset: 0x001C62AC
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe CGProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CGProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(CGProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005844 RID: 22596 RVA: 0x0002F4DA File Offset: 0x0002D6DA
		public CGProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E5C RID: 7772
		// (get) Token: 0x06005845 RID: 22597 RVA: 0x001C80E8 File Offset: 0x001C62E8
		// (set) Token: 0x06005846 RID: 22598 RVA: 0x0002F4E3 File Offset: 0x0002D6E3
		public unsafe Il2CppReferenceArray<CGProfile.CGPictureProperty> cgPictures
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CGProfile.NativeFieldInfoPtr_cgPictures);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<CGProfile.CGPictureProperty>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CGProfile.NativeFieldInfoPtr_cgPictures), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003B22 RID: 15138
		private static readonly IntPtr NativeFieldInfoPtr_cgPictures;

		// Token: 0x04003B23 RID: 15139
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C8F RID: 3215
		[Serializable]
		public sealed class CGPictureProperty : ValueType
		{
			// Token: 0x0600E6EE RID: 59118 RVA: 0x00376570 File Offset: 0x00374770
			// Note: this type is marked as 'beforefieldinit'.
			static CGPictureProperty()
			{
				Il2CppClassPointerStore<CGProfile.CGPictureProperty>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<CGProfile>.NativeClassPtr, "CGPictureProperty");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<CGProfile.CGPictureProperty>.NativeClassPtr);
				CGProfile.CGPictureProperty.NativeFieldInfoPtr_CGKey = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CGProfile.CGPictureProperty>.NativeClassPtr, "CGKey");
				CGProfile.CGPictureProperty.NativeFieldInfoPtr_cgPictures = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CGProfile.CGPictureProperty>.NativeClassPtr, "cgPictures");
				CGProfile.CGPictureProperty.NativeFieldInfoPtr_haveLinkedCG = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CGProfile.CGPictureProperty>.NativeClassPtr, "haveLinkedCG");
				CGProfile.CGPictureProperty.NativeFieldInfoPtr_linkedCGLabel = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<CGProfile.CGPictureProperty>.NativeClassPtr, "linkedCGLabel");
			}

			// Token: 0x0600E6EF RID: 59119 RVA: 0x0007B39F File Offset: 0x0007959F
			public CGPictureProperty(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E6F0 RID: 59120 RVA: 0x0007B3A8 File Offset: 0x000795A8
			public CGPictureProperty() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<CGProfile.CGPictureProperty>.NativeClassPtr))
			{
			}

			// Token: 0x17004ADF RID: 19167
			// (get) Token: 0x0600E6F1 RID: 59121 RVA: 0x003765EC File Offset: 0x003747EC
			// (set) Token: 0x0600E6F2 RID: 59122 RVA: 0x0007B3BA File Offset: 0x000795BA
			public unsafe string CGKey
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CGProfile.CGPictureProperty.NativeFieldInfoPtr_CGKey);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CGProfile.CGPictureProperty.NativeFieldInfoPtr_CGKey), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004AE0 RID: 19168
			// (get) Token: 0x0600E6F3 RID: 59123 RVA: 0x00376614 File Offset: 0x00374814
			// (set) Token: 0x0600E6F4 RID: 59124 RVA: 0x0007B3D9 File Offset: 0x000795D9
			public unsafe Il2CppReferenceArray<RunTimeScheduler.CGPicture> cgPictures
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CGProfile.CGPictureProperty.NativeFieldInfoPtr_cgPictures);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<RunTimeScheduler.CGPicture>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CGProfile.CGPictureProperty.NativeFieldInfoPtr_cgPictures), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x17004AE1 RID: 19169
			// (get) Token: 0x0600E6F5 RID: 59125 RVA: 0x00376644 File Offset: 0x00374844
			// (set) Token: 0x0600E6F6 RID: 59126 RVA: 0x0007B3F8 File Offset: 0x000795F8
			public unsafe bool haveLinkedCG
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CGProfile.CGPictureProperty.NativeFieldInfoPtr_haveLinkedCG);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CGProfile.CGPictureProperty.NativeFieldInfoPtr_haveLinkedCG)) = value;
				}
			}

			// Token: 0x17004AE2 RID: 19170
			// (get) Token: 0x0600E6F7 RID: 59127 RVA: 0x0037666C File Offset: 0x0037486C
			// (set) Token: 0x0600E6F8 RID: 59128 RVA: 0x0007B413 File Offset: 0x00079613
			public unsafe string linkedCGLabel
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(CGProfile.CGPictureProperty.NativeFieldInfoPtr_linkedCGLabel);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(CGProfile.CGPictureProperty.NativeFieldInfoPtr_linkedCGLabel), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x0400937C RID: 37756
			private static readonly IntPtr NativeFieldInfoPtr_CGKey;

			// Token: 0x0400937D RID: 37757
			private static readonly IntPtr NativeFieldInfoPtr_cgPictures;

			// Token: 0x0400937E RID: 37758
			private static readonly IntPtr NativeFieldInfoPtr_haveLinkedCG;

			// Token: 0x0400937F RID: 37759
			private static readonly IntPtr NativeFieldInfoPtr_linkedCGLabel;
		}
	}
}
