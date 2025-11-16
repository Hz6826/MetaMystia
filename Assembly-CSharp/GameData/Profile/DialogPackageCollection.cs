using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002D3 RID: 723
	public class DialogPackageCollection : ScriptableObject
	{
		// Token: 0x060058A7 RID: 22695 RVA: 0x001C90E8 File Offset: 0x001C72E8
		// Note: this type is marked as 'beforefieldinit'.
		static DialogPackageCollection()
		{
			Il2CppClassPointerStore<DialogPackageCollection>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "DialogPackageCollection");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogPackageCollection>.NativeClassPtr);
			DialogPackageCollection.NativeFieldInfoPtr_allDialogPackages = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPackageCollection>.NativeClassPtr, "allDialogPackages");
			DialogPackageCollection.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPackageCollection>.NativeClassPtr, 100681272);
		}

		// Token: 0x060058A8 RID: 22696 RVA: 0x001C9140 File Offset: 0x001C7340
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogPackageCollection() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogPackageCollection>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPackageCollection.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060058A9 RID: 22697 RVA: 0x0002F86E File Offset: 0x0002DA6E
		public DialogPackageCollection(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E76 RID: 7798
		// (get) Token: 0x060058AA RID: 22698 RVA: 0x001C917C File Offset: 0x001C737C
		// (set) Token: 0x060058AB RID: 22699 RVA: 0x0002F877 File Offset: 0x0002DA77
		public unsafe Il2CppReferenceArray<DialogPackageCollection.IDPackagePair> allDialogPackages
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPackageCollection.NativeFieldInfoPtr_allDialogPackages);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogPackageCollection.IDPackagePair>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPackageCollection.NativeFieldInfoPtr_allDialogPackages), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003B51 RID: 15185
		private static readonly IntPtr NativeFieldInfoPtr_allDialogPackages;

		// Token: 0x04003B52 RID: 15186
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000C95 RID: 3221
		[Serializable]
		public sealed class IDPackagePair : ValueType
		{
			// Token: 0x0600E73E RID: 59198 RVA: 0x00376F9C File Offset: 0x0037519C
			// Note: this type is marked as 'beforefieldinit'.
			static IDPackagePair()
			{
				Il2CppClassPointerStore<DialogPackageCollection.IDPackagePair>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<DialogPackageCollection>.NativeClassPtr, "IDPackagePair");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogPackageCollection.IDPackagePair>.NativeClassPtr);
				DialogPackageCollection.IDPackagePair.NativeFieldInfoPtr_id = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPackageCollection.IDPackagePair>.NativeClassPtr, "id");
				DialogPackageCollection.IDPackagePair.NativeFieldInfoPtr_dialogPackage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPackageCollection.IDPackagePair>.NativeClassPtr, "dialogPackage");
			}

			// Token: 0x0600E73F RID: 59199 RVA: 0x0007B767 File Offset: 0x00079967
			public IDPackagePair(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x0600E740 RID: 59200 RVA: 0x0007B770 File Offset: 0x00079970
			public IDPackagePair() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogPackageCollection.IDPackagePair>.NativeClassPtr))
			{
			}

			// Token: 0x17004AFD RID: 19197
			// (get) Token: 0x0600E741 RID: 59201 RVA: 0x00376FF0 File Offset: 0x003751F0
			// (set) Token: 0x0600E742 RID: 59202 RVA: 0x0007B782 File Offset: 0x00079982
			public unsafe int id
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPackageCollection.IDPackagePair.NativeFieldInfoPtr_id);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPackageCollection.IDPackagePair.NativeFieldInfoPtr_id)) = value;
				}
			}

			// Token: 0x17004AFE RID: 19198
			// (get) Token: 0x0600E743 RID: 59203 RVA: 0x00377018 File Offset: 0x00375218
			// (set) Token: 0x0600E744 RID: 59204 RVA: 0x0007B79D File Offset: 0x0007999D
			public unsafe DialogPackage dialogPackage
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPackageCollection.IDPackagePair.NativeFieldInfoPtr_dialogPackage);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPackageCollection.IDPackagePair.NativeFieldInfoPtr_dialogPackage), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x0400939F RID: 37791
			private static readonly IntPtr NativeFieldInfoPtr_id;

			// Token: 0x040093A0 RID: 37792
			private static readonly IntPtr NativeFieldInfoPtr_dialogPackage;
		}
	}
}
