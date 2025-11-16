using System;
using GameData.Core.Collections;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.InteropTypes.Arrays;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;

namespace GameData.Profile
{
	// Token: 0x020002D1 RID: 721
	public class DecorationProfile : ScriptableObject
	{
		// Token: 0x06005899 RID: 22681 RVA: 0x001C8ED8 File Offset: 0x001C70D8
		// Note: this type is marked as 'beforefieldinit'.
		static DecorationProfile()
		{
			Il2CppClassPointerStore<DecorationProfile>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "GameData.Profile", "DecorationProfile");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<DecorationProfile>.NativeClassPtr);
			DecorationProfile.NativeFieldInfoPtr_decorations = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecorationProfile>.NativeClassPtr, "decorations");
			DecorationProfile.NativeFieldInfoPtr_previews = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecorationProfile>.NativeClassPtr, "previews");
			DecorationProfile.NativeFieldInfoPtr_tsvBackup = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<DecorationProfile>.NativeClassPtr, "tsvBackup");
			DecorationProfile.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<DecorationProfile>.NativeClassPtr, 100681270);
		}

		// Token: 0x0600589A RID: 22682 RVA: 0x001C8F58 File Offset: 0x001C7158
		[CallerCount(227)]
		[CachedScanResults(RefRangeStart = 71601, RefRangeEnd = 71828, XrefRangeStart = 71601, XrefRangeEnd = 71828, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe DecorationProfile() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<DecorationProfile>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(DecorationProfile.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x0600589B RID: 22683 RVA: 0x0002F7E0 File Offset: 0x0002D9E0
		public DecorationProfile(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17001E72 RID: 7794
		// (get) Token: 0x0600589C RID: 22684 RVA: 0x001C8F94 File Offset: 0x001C7194
		// (set) Token: 0x0600589D RID: 22685 RVA: 0x0002F7E9 File Offset: 0x0002D9E9
		public unsafe Il2CppReferenceArray<Decoration> decorations
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecorationProfile.NativeFieldInfoPtr_decorations);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Il2CppReferenceArray<Decoration>>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecorationProfile.NativeFieldInfoPtr_decorations), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E73 RID: 7795
		// (get) Token: 0x0600589E RID: 22686 RVA: 0x001C8FC4 File Offset: 0x001C71C4
		// (set) Token: 0x0600589F RID: 22687 RVA: 0x0002F808 File Offset: 0x0002DA08
		public unsafe TextAsset previews
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecorationProfile.NativeFieldInfoPtr_previews);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecorationProfile.NativeFieldInfoPtr_previews), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17001E74 RID: 7796
		// (get) Token: 0x060058A0 RID: 22688 RVA: 0x001C8FF4 File Offset: 0x001C71F4
		// (set) Token: 0x060058A1 RID: 22689 RVA: 0x0002F827 File Offset: 0x0002DA27
		public unsafe TextAsset tsvBackup
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecorationProfile.NativeFieldInfoPtr_tsvBackup);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<TextAsset>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(DecorationProfile.NativeFieldInfoPtr_tsvBackup), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x04003B4B RID: 15179
		private static readonly IntPtr NativeFieldInfoPtr_decorations;

		// Token: 0x04003B4C RID: 15180
		private static readonly IntPtr NativeFieldInfoPtr_previews;

		// Token: 0x04003B4D RID: 15181
		private static readonly IntPtr NativeFieldInfoPtr_tsvBackup;

		// Token: 0x04003B4E RID: 15182
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
