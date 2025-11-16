using System;
using GameData.Profile;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using UnityEngine;
using UnityEngine.Playables;

namespace Common.TimelineExtestion
{
	// Token: 0x020003F0 RID: 1008
	public class COM_ADialog_Play : PlayableAsset
	{
		// Token: 0x060076B6 RID: 30390 RVA: 0x00229CE8 File Offset: 0x00227EE8
		// Note: this type is marked as 'beforefieldinit'.
		static COM_ADialog_Play()
		{
			Il2CppClassPointerStore<COM_ADialog_Play>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.TimelineExtestion", "COM_ADialog_Play");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<COM_ADialog_Play>.NativeClassPtr);
			COM_ADialog_Play.NativeFieldInfoPtr_dialogPackage = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ADialog_Play>.NativeClassPtr, "dialogPackage");
			COM_ADialog_Play.NativeFieldInfoPtr_PreservePreviousPannelVisual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<COM_ADialog_Play>.NativeClassPtr, "PreservePreviousPannelVisual");
			COM_ADialog_Play.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ADialog_Play>.NativeClassPtr, 100687523);
			COM_ADialog_Play.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<COM_ADialog_Play>.NativeClassPtr, 100687524);
		}

		// Token: 0x060076B7 RID: 30391 RVA: 0x00229D68 File Offset: 0x00227F68
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 292857, XrefRangeEnd = 292872, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe override Playable CreatePlayable(PlayableGraph graph, GameObject owner)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = ref graph;
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(owner);
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), COM_ADialog_Play.NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			return *IL2CPP.il2cpp_object_unbox(intPtr);
		}

		// Token: 0x060076B8 RID: 30392 RVA: 0x00229DD0 File Offset: 0x00227FD0
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 40720, RefRangeEnd = 40722, XrefRangeStart = 40720, XrefRangeEnd = 40722, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe COM_ADialog_Play() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<COM_ADialog_Play>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(COM_ADialog_Play.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x060076B9 RID: 30393 RVA: 0x000403CC File Offset: 0x0003E5CC
		public COM_ADialog_Play(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002881 RID: 10369
		// (get) Token: 0x060076BA RID: 30394 RVA: 0x00229E0C File Offset: 0x0022800C
		// (set) Token: 0x060076BB RID: 30395 RVA: 0x000403D5 File Offset: 0x0003E5D5
		public unsafe DialogPackage dialogPackage
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ADialog_Play.NativeFieldInfoPtr_dialogPackage);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<DialogPackage>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ADialog_Play.NativeFieldInfoPtr_dialogPackage), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002882 RID: 10370
		// (get) Token: 0x060076BC RID: 30396 RVA: 0x00229E3C File Offset: 0x0022803C
		// (set) Token: 0x060076BD RID: 30397 RVA: 0x000403F4 File Offset: 0x0003E5F4
		public unsafe bool PreservePreviousPannelVisual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ADialog_Play.NativeFieldInfoPtr_PreservePreviousPannelVisual);
				return *intPtr;
			}
			set
			{
				*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(COM_ADialog_Play.NativeFieldInfoPtr_PreservePreviousPannelVisual)) = value;
			}
		}

		// Token: 0x04004E8A RID: 20106
		private static readonly IntPtr NativeFieldInfoPtr_dialogPackage;

		// Token: 0x04004E8B RID: 20107
		private static readonly IntPtr NativeFieldInfoPtr_PreservePreviousPannelVisual;

		// Token: 0x04004E8C RID: 20108
		private static readonly IntPtr NativeMethodInfoPtr_CreatePlayable_Public_Virtual_Playable_PlayableGraph_GameObject_0;

		// Token: 0x04004E8D RID: 20109
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;
	}
}
