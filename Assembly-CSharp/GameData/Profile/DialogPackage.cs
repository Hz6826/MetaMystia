using System;
using Common.DialogUtility;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002F1 RID: 753
	public class DialogPackage : ScriptableObject
	{
		// Token: 0x06005A5D RID: 23133 RVA: 0x001CD2A0 File Offset: 0x001CB4A0
		// Note: this type is marked as 'beforefieldinit'.
		static DialogPackage()
		{
			Il2CppClassPointerStore<DialogPackage>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "DialogPackage");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DialogPackage>.NativeClassPtr);
			DialogPackage.NativeFieldInfoPtr_dialogContext = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPackage>.NativeClassPtr, "dialogContext");
			DialogPackage.NativeFieldInfoPtr_dialogMeta = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DialogPackage>.NativeClassPtr, "dialogMeta");
			DialogPackage.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DialogPackage>.NativeClassPtr, 100681431);
		}

		// Token: 0x06005A5E RID: 23134 RVA: 0x001CD30C File Offset: 0x001CB50C
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DialogPackage() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DialogPackage>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DialogPackage.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06005A5F RID: 23135 RVA: 0x00030D47 File Offset: 0x0002EF47
		public DialogPackage(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001F21 RID: 7969
		// (get) Token: 0x06005A60 RID: 23136 RVA: 0x001CD348 File Offset: 0x001CB548
		// (set) Token: 0x06005A61 RID: 23137 RVA: 0x00030D50 File Offset: 0x0002EF50
		public unsafe MultiLanguageTextMesh.MultiLanguageAssetReference dialogContext
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPackage.NativeFieldInfoPtr_dialogContext);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<MultiLanguageTextMesh.MultiLanguageAssetReference>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPackage.NativeFieldInfoPtr_dialogContext), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001F22 RID: 7970
		// (get) Token: 0x06005A62 RID: 23138 RVA: 0x001CD378 File Offset: 0x001CB578
		// (set) Token: 0x06005A63 RID: 23139 RVA: 0x00030D6F File Offset: 0x0002EF6F
		public unsafe Il2CppReferenceArray<DialogMeta> dialogMeta
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPackage.NativeFieldInfoPtr_dialogMeta);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<DialogMeta>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DialogPackage.NativeFieldInfoPtr_dialogMeta), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003C27 RID: 15399
		private static readonly IntPtr NativeFieldInfoPtr_dialogContext;

		// Token: 0x04003C28 RID: 15400
		private static readonly IntPtr NativeFieldInfoPtr_dialogMeta;

		// Token: 0x04003C29 RID: 15401
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
