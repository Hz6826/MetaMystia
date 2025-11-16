using System;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;

namespace Common.DialogUtility
{
	// Token: 0x02000341 RID: 833
	public class ManualDialogPannelOpenContext : DialogPannelOpenContextBase
	{
		// Token: 0x0600636A RID: 25450 RVA: 0x001EAD80 File Offset: 0x001E8F80
		// Note: this type is marked as 'beforefieldinit'.
		static ManualDialogPannelOpenContext()
		{
			Il2CppClassPointerStore<ManualDialogPannelOpenContext>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.DialogUtility", "ManualDialogPannelOpenContext");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<ManualDialogPannelOpenContext>.NativeClassPtr);
			ManualDialogPannelOpenContext.NativeFieldInfoPtr_OnDialogFinishCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualDialogPannelOpenContext>.NativeClassPtr, "OnDialogFinishCallback");
			ManualDialogPannelOpenContext.NativeFieldInfoPtr_OnLoadFinishCallback = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualDialogPannelOpenContext>.NativeClassPtr, "OnLoadFinishCallback");
			ManualDialogPannelOpenContext.NativeFieldInfoPtr_OpenWithBlackBackground = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<ManualDialogPannelOpenContext>.NativeClassPtr, "OpenWithBlackBackground");
			ManualDialogPannelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_DialogPackage_Boolean_Action_Action_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualDialogPannelOpenContext>.NativeClassPtr, 100684217);
			ManualDialogPannelOpenContext.NativeMethodInfoPtr_get_ManualMode_Public_Virtual_get_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<ManualDialogPannelOpenContext>.NativeClassPtr, 100684218);
		}

		// Token: 0x0600636B RID: 25451 RVA: 0x001EAE14 File Offset: 0x001E9014
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 257102, XrefRangeEnd = 257114, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe ManualDialogPannelOpenContext(DialogPackage dialogPackageToPlay, bool openWithBlackBackground, Action onDialogFinishCallback, Action onLoadFinishCallback) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<ManualDialogPannelOpenContext>.NativeClassPtr))
		{
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)4) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.Il2CppObjectBaseToPtr(dialogPackageToPlay);
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref openWithBlackBackground;
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onDialogFinishCallback);
			ptr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(onLoadFinishCallback);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(ManualDialogPannelOpenContext.NativeMethodInfoPtr__ctor_Public_Void_DialogPackage_Boolean_Action_Action_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x1700223F RID: 8767
		// (get) Token: 0x0600636C RID: 25452 RVA: 0x001EAE94 File Offset: 0x001E9094
		public unsafe override bool ManualMode
		{
			[CallerCount(19)]
			[CachedScanResults(RefRangeStart = 19576, RefRangeEnd = 19595, XrefRangeStart = 19576, XrefRangeEnd = 19595, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			get
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = null;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), ManualDialogPannelOpenContext.NativeMethodInfoPtr_get_ManualMode_Public_Virtual_get_Boolean_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
				return *IL2CPP.il2cpp_object_unbox(intPtr);
			}
		}

		// Token: 0x0600636D RID: 25453 RVA: 0x00035B6F File Offset: 0x00033D6F
		public ManualDialogPannelOpenContext(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x1700223C RID: 8764
		// (get) Token: 0x0600636E RID: 25454 RVA: 0x001EAEDC File Offset: 0x001E90DC
		// (set) Token: 0x0600636F RID: 25455 RVA: 0x00035B78 File Offset: 0x00033D78
		public unsafe Action OnDialogFinishCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManualDialogPannelOpenContext.NativeFieldInfoPtr_OnDialogFinishCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManualDialogPannelOpenContext.NativeFieldInfoPtr_OnDialogFinishCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700223D RID: 8765
		// (get) Token: 0x06006370 RID: 25456 RVA: 0x001EAF0C File Offset: 0x001E910C
		// (set) Token: 0x06006371 RID: 25457 RVA: 0x00035B97 File Offset: 0x00033D97
		public unsafe Action OnLoadFinishCallback
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManualDialogPannelOpenContext.NativeFieldInfoPtr_OnLoadFinishCallback);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Action>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManualDialogPannelOpenContext.NativeFieldInfoPtr_OnLoadFinishCallback), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x1700223E RID: 8766
		// (get) Token: 0x06006372 RID: 25458 RVA: 0x001EAF3C File Offset: 0x001E913C
		// (set) Token: 0x06006373 RID: 25459 RVA: 0x00035BB6 File Offset: 0x00033DB6
		public unsafe bool OpenWithBlackBackground
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManualDialogPannelOpenContext.NativeFieldInfoPtr_OpenWithBlackBackground);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(ManualDialogPannelOpenContext.NativeFieldInfoPtr_OpenWithBlackBackground)) = value;
			}
		}

		// Token: 0x040041E7 RID: 16871
		private static readonly IntPtr NativeFieldInfoPtr_OnDialogFinishCallback;

		// Token: 0x040041E8 RID: 16872
		private static readonly IntPtr NativeFieldInfoPtr_OnLoadFinishCallback;

		// Token: 0x040041E9 RID: 16873
		private static readonly IntPtr NativeFieldInfoPtr_OpenWithBlackBackground;

		// Token: 0x040041EA RID: 16874
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_DialogPackage_Boolean_Action_Action_0;

		// Token: 0x040041EB RID: 16875
		private static readonly IntPtr NativeMethodInfoPtr_get_ManualMode_Public_Virtual_get_Boolean_0;
	}
}
