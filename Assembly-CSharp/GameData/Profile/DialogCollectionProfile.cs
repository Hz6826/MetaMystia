using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002D2 RID: 722
	public class DialogCollectionProfile : ScriptableObject
	{
		// Token: 0x060058A2 RID: 22690 RVA: 0x001C9024 File Offset: 0x001C7224
		// Note: this type is marked as 'beforefieldinit'.
		static DialogCollectionProfile()
		{
			Il2CppClassPointerStore<DialogCollectionProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "DialogCollectionProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogCollectionProfile>.NativeClassPtr);
			DialogCollectionProfile.NativeFieldInfoPtr_allContents = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogCollectionProfile>.NativeClassPtr, "allContents");
			DialogCollectionProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogCollectionProfile>.NativeClassPtr, 100681271);
		}

		// Token: 0x060058A3 RID: 22691 RVA: 0x001C907C File Offset: 0x001C727C
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogCollectionProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogCollectionProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogCollectionProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058A4 RID: 22692 RVA: 0x0002F846 File Offset: 0x0002DA46
		public DialogCollectionProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E75 RID: 7797
		// (get) Token: 0x060058A5 RID: 22693 RVA: 0x001C90B8 File Offset: 0x001C72B8
		// (set) Token: 0x060058A6 RID: 22694 RVA: 0x0002F84F File Offset: 0x0002DA4F
		public unsafe Il2CppReferenceArray<DialogCollectionProfile.IDTextPair> allContents
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogCollectionProfile.NativeFieldInfoPtr_allContents);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogCollectionProfile.IDTextPair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogCollectionProfile.NativeFieldInfoPtr_allContents), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003B4F RID: 15183
		private static readonly IntPtr NativeFieldInfoPtr_allContents;

		// Token: 0x04003B50 RID: 15184
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C94 RID: 3220
		[Serializable]
		public sealed class IDTextPair : ValueType
		{
			// Token: 0x0600E737 RID: 59191 RVA: 0x00376EF0 File Offset: 0x003750F0
			// Note: this type is marked as 'beforefieldinit'.
			static IDTextPair()
			{
				Il2CppClassPointerStore<DialogCollectionProfile.IDTextPair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogCollectionProfile>.NativeClassPtr, "IDTextPair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogCollectionProfile.IDTextPair>.NativeClassPtr);
				DialogCollectionProfile.IDTextPair.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogCollectionProfile.IDTextPair>.NativeClassPtr, "id");
				DialogCollectionProfile.IDTextPair.NativeFieldInfoPtr_dialogePack = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogCollectionProfile.IDTextPair>.NativeClassPtr, "dialogePack");
			}

			// Token: 0x0600E738 RID: 59192 RVA: 0x0007B70E File Offset: 0x0007990E
			public IDTextPair(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E739 RID: 59193 RVA: 0x0007B717 File Offset: 0x00079917
			public IDTextPair() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogCollectionProfile.IDTextPair>.NativeClassPtr))
			{
			}

			// Token: 0x17004AFB RID: 19195
			// (get) Token: 0x0600E73A RID: 59194 RVA: 0x00376F44 File Offset: 0x00375144
			// (set) Token: 0x0600E73B RID: 59195 RVA: 0x0007B729 File Offset: 0x00079929
			public unsafe string id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogCollectionProfile.IDTextPair.NativeFieldInfoPtr_id);
					return IL2CPP.Il2CppStringToManaged(*intPtr);
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogCollectionProfile.IDTextPair.NativeFieldInfoPtr_id), IL2CPP.ManagedStringToIl2Cpp(value));
				}
			}

			// Token: 0x17004AFC RID: 19196
			// (get) Token: 0x0600E73C RID: 59196 RVA: 0x00376F6C File Offset: 0x0037516C
			// (set) Token: 0x0600E73D RID: 59197 RVA: 0x0007B748 File Offset: 0x00079948
			public unsafe DialogPackage dialogePack
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogCollectionProfile.IDTextPair.NativeFieldInfoPtr_dialogePack);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogCollectionProfile.IDTextPair.NativeFieldInfoPtr_dialogePack), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400939D RID: 37789
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x0400939E RID: 37790
			private static readonly IntPtr NativeFieldInfoPtr_dialogePack;
		}
	}
}
