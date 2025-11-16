using System;
using Il2CppInterop.Common.Attributes;
using Il2CppInterop.Runtime;
using Il2CppInterop.Runtime.Runtime;
using Il2CppSystem;
using Il2CppSystem.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.UI;

namespace Common.UI.QTEUtility
{
	// Token: 0x0200038C RID: 908
	public class NoteHeadFinishAnimationController : MonoBehaviour
	{
		// Token: 0x06006C7C RID: 27772 RVA: 0x00208380 File Offset: 0x00206580
		// Note: this type is marked as 'beforefieldinit'.
		static NoteHeadFinishAnimationController()
		{
			Il2CppClassPointerStore<NoteHeadFinishAnimationController>.NativeClassPtr = IL2CPP.GetIl2CppClass("Assembly-CSharp.dll", "Common.UI.QTEUtility", "NoteHeadFinishAnimationController");
			IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteHeadFinishAnimationController>.NativeClassPtr);
			NoteHeadFinishAnimationController.NativeFieldInfoPtr_m_Animator = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteHeadFinishAnimationController>.NativeClassPtr, "m_Animator");
			NoteHeadFinishAnimationController.NativeFieldInfoPtr_m_Visual = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteHeadFinishAnimationController>.NativeClassPtr, "m_Visual");
			NoteHeadFinishAnimationController.NativeFieldInfoPtr_m_OnReleaseHandle = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteHeadFinishAnimationController>.NativeClassPtr, "m_OnReleaseHandle");
			NoteHeadFinishAnimationController.NativeMethodInfoPtr_OnDestroy_Private_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadFinishAnimationController>.NativeClassPtr, 100685635);
			NoteHeadFinishAnimationController.NativeMethodInfoPtr_Play_Public_Void_RemoveContext_Sprite_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadFinishAnimationController>.NativeClassPtr, 100685636);
			NoteHeadFinishAnimationController.NativeMethodInfoPtr_Play_Public_Void_RemoveContext_Vector3_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadFinishAnimationController>.NativeClassPtr, 100685637);
			NoteHeadFinishAnimationController.NativeMethodInfoPtr_Release_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadFinishAnimationController>.NativeClassPtr, 100685638);
			NoteHeadFinishAnimationController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadFinishAnimationController>.NativeClassPtr, 100685639);
			NoteHeadFinishAnimationController.NativeMethodInfoPtr__ctor_Public_Void_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadFinishAnimationController>.NativeClassPtr, 100685640);
		}

		// Token: 0x06006C7D RID: 27773 RVA: 0x00208464 File Offset: 0x00206664
		[CallerCount(0)]
		public unsafe void OnDestroy()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadFinishAnimationController.NativeMethodInfoPtr_OnDestroy_Private_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C7E RID: 27774 RVA: 0x00208498 File Offset: 0x00206698
		[CallerCount(5)]
		[CachedScanResults(RefRangeStart = 273627, RefRangeEnd = 273632, XrefRangeStart = 273619, XrefRangeEnd = 273627, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play(NoteHeadFinishAnimationController.RemoveContext onReleaseHandle, Sprite visual, Vector3 worldPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)3) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(onReleaseHandle));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(visual);
			ptr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadFinishAnimationController.NativeMethodInfoPtr_Play_Public_Void_RemoveContext_Sprite_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C7F RID: 27775 RVA: 0x00208500 File Offset: 0x00206700
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 273639, RefRangeEnd = 273641, XrefRangeStart = 273632, XrefRangeEnd = 273639, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Play(NoteHeadFinishAnimationController.RemoveContext onReleaseHandle, Vector3 worldPosition)
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
			*ptr = IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(onReleaseHandle));
			ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = ref worldPosition;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadFinishAnimationController.NativeMethodInfoPtr_Play_Public_Void_RemoveContext_Vector3_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C80 RID: 27776 RVA: 0x00208558 File Offset: 0x00206758
		[CallerCount(2)]
		[CachedScanResults(RefRangeStart = 273644, RefRangeEnd = 273646, XrefRangeStart = 273641, XrefRangeEnd = 273644, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe void Release()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadFinishAnimationController.NativeMethodInfoPtr_Release_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C81 RID: 27777 RVA: 0x0020858C File Offset: 0x0020678C
		[CallerCount(0)]
		[CachedScanResults(RefRangeStart = 0, RefRangeEnd = 0, XrefRangeStart = 0, XrefRangeEnd = 0, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe virtual void Cleanup_Generated()
		{
			IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(IL2CPP.il2cpp_object_get_virtual_method(IL2CPP.Il2CppObjectBaseToPtr(this), NoteHeadFinishAnimationController.NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0), IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C82 RID: 27778 RVA: 0x002085C8 File Offset: 0x002067C8
		[CallerCount(197)]
		[CachedScanResults(RefRangeStart = 190, RefRangeEnd = 387, XrefRangeStart = 190, XrefRangeEnd = 387, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
		public unsafe NoteHeadFinishAnimationController() : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteHeadFinishAnimationController>.NativeClassPtr))
		{
			IntPtr* ptr = null;
			IntPtr intPtr2;
			IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadFinishAnimationController.NativeMethodInfoPtr__ctor_Public_Void_0, IL2CPP.Il2CppObjectBaseToPtrNotNull(this), (void**)ptr, ref intPtr2);
			Il2CppException.RaiseExceptionIfNecessary(intPtr2);
		}

		// Token: 0x06006C83 RID: 27779 RVA: 0x0003AB06 File Offset: 0x00038D06
		public NoteHeadFinishAnimationController(IntPtr pointer) : base(pointer)
		{
		}

		// Token: 0x17002523 RID: 9507
		// (get) Token: 0x06006C84 RID: 27780 RVA: 0x00208604 File Offset: 0x00206804
		// (set) Token: 0x06006C85 RID: 27781 RVA: 0x0003AB0F File Offset: 0x00038D0F
		public unsafe Animator m_Animator
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadFinishAnimationController.NativeFieldInfoPtr_m_Animator);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Animator>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadFinishAnimationController.NativeFieldInfoPtr_m_Animator), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002524 RID: 9508
		// (get) Token: 0x06006C86 RID: 27782 RVA: 0x00208634 File Offset: 0x00206834
		// (set) Token: 0x06006C87 RID: 27783 RVA: 0x0003AB2E File Offset: 0x00038D2E
		public unsafe Image m_Visual
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadFinishAnimationController.NativeFieldInfoPtr_m_Visual);
				IntPtr intPtr2 = *intPtr;
				return (intPtr2 != 0) ? Il2CppObjectPool.Get<Image>(intPtr2) : null;
			}
			set
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadFinishAnimationController.NativeFieldInfoPtr_m_Visual), IL2CPP.Il2CppObjectBaseToPtr(value));
			}
		}

		// Token: 0x17002525 RID: 9509
		// (get) Token: 0x06006C88 RID: 27784 RVA: 0x00208664 File Offset: 0x00206864
		// (set) Token: 0x06006C89 RID: 27785 RVA: 0x0003AB4D File Offset: 0x00038D4D
		public NoteHeadFinishAnimationController.RemoveContext m_OnReleaseHandle
		{
			get
			{
				IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadFinishAnimationController.NativeFieldInfoPtr_m_OnReleaseHandle);
				return new NoteHeadFinishAnimationController.RemoveContext(IL2CPP.il2cpp_value_box(Il2CppClassPointerStore<NoteHeadFinishAnimationController.RemoveContext>.NativeClassPtr, intPtr));
			}
			set
			{
				cpblk(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadFinishAnimationController.NativeFieldInfoPtr_m_OnReleaseHandle), IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtr(value)), IL2CPP.il2cpp_class_value_size(Il2CppClassPointerStore<NoteHeadFinishAnimationController.RemoveContext>.NativeClassPtr, (UIntPtr)0));
			}
		}

		// Token: 0x040047EC RID: 18412
		private static readonly IntPtr NativeFieldInfoPtr_m_Animator;

		// Token: 0x040047ED RID: 18413
		private static readonly IntPtr NativeFieldInfoPtr_m_Visual;

		// Token: 0x040047EE RID: 18414
		private static readonly IntPtr NativeFieldInfoPtr_m_OnReleaseHandle;

		// Token: 0x040047EF RID: 18415
		private static readonly IntPtr NativeMethodInfoPtr_OnDestroy_Private_Void_0;

		// Token: 0x040047F0 RID: 18416
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_RemoveContext_Sprite_Vector3_0;

		// Token: 0x040047F1 RID: 18417
		private static readonly IntPtr NativeMethodInfoPtr_Play_Public_Void_RemoveContext_Vector3_0;

		// Token: 0x040047F2 RID: 18418
		private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_0;

		// Token: 0x040047F3 RID: 18419
		private static readonly IntPtr NativeMethodInfoPtr_Cleanup_Generated_Protected_Virtual_New_Void_0;

		// Token: 0x040047F4 RID: 18420
		private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_0;

		// Token: 0x02000EB8 RID: 3768
		public sealed class RemoveContext : ValueType
		{
			// Token: 0x060109F6 RID: 68086 RVA: 0x003D9884 File Offset: 0x003D7A84
			// Note: this type is marked as 'beforefieldinit'.
			static RemoveContext()
			{
				Il2CppClassPointerStore<NoteHeadFinishAnimationController.RemoveContext>.NativeClassPtr = IL2CPP.GetIl2CppNestedType(Il2CppClassPointerStore<NoteHeadFinishAnimationController>.NativeClassPtr, "RemoveContext");
				IL2CPP.il2cpp_runtime_class_init(Il2CppClassPointerStore<NoteHeadFinishAnimationController.RemoveContext>.NativeClassPtr);
				NoteHeadFinishAnimationController.RemoveContext.NativeFieldInfoPtr__active = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteHeadFinishAnimationController.RemoveContext>.NativeClassPtr, "_active");
				NoteHeadFinishAnimationController.RemoveContext.NativeFieldInfoPtr__pool = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteHeadFinishAnimationController.RemoveContext>.NativeClassPtr, "_pool");
				NoteHeadFinishAnimationController.RemoveContext.NativeFieldInfoPtr__destroyInstance = IL2CPP.GetIl2CppField(Il2CppClassPointerStore<NoteHeadFinishAnimationController.RemoveContext>.NativeClassPtr, "_destroyInstance");
				NoteHeadFinishAnimationController.RemoveContext.NativeMethodInfoPtr__ctor_Public_Void_HashSet_1_NoteHeadFinishAnimationController_ObjectPool_1_NoteHeadFinishAnimationController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadFinishAnimationController.RemoveContext>.NativeClassPtr, 100685641);
				NoteHeadFinishAnimationController.RemoveContext.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadFinishAnimationController.RemoveContext>.NativeClassPtr, 100685642);
				NoteHeadFinishAnimationController.RemoveContext.NativeMethodInfoPtr_Release_Public_Void_NoteHeadFinishAnimationController_0 = IL2CPP.GetIl2CppMethodByToken(Il2CppClassPointerStore<NoteHeadFinishAnimationController.RemoveContext>.NativeClassPtr, 100685643);
			}

			// Token: 0x060109F7 RID: 68087 RVA: 0x003D9928 File Offset: 0x003D7B28
			[CallerCount(5)]
			[CachedScanResults(RefRangeStart = 273597, RefRangeEnd = 273602, XrefRangeStart = 273595, XrefRangeEnd = 273597, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RemoveContext(HashSet<NoteHeadFinishAnimationController> active, ObjectPool<NoteHeadFinishAnimationController> pool) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteHeadFinishAnimationController.RemoveContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)2) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(active);
				ptr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr)) / (UIntPtr)sizeof(IntPtr)] = IL2CPP.Il2CppObjectBaseToPtr(pool);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadFinishAnimationController.RemoveContext.NativeMethodInfoPtr__ctor_Public_Void_HashSet_1_NoteHeadFinishAnimationController_ObjectPool_1_NoteHeadFinishAnimationController_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060109F8 RID: 68088 RVA: 0x003D998C File Offset: 0x003D7B8C
			[CallerCount(2)]
			[CachedScanResults(RefRangeStart = 273604, RefRangeEnd = 273606, XrefRangeStart = 273602, XrefRangeEnd = 273604, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe RemoveContext(bool destroyInstance) : this(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteHeadFinishAnimationController.RemoveContext>.NativeClassPtr))
			{
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = ref destroyInstance;
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadFinishAnimationController.RemoveContext.NativeMethodInfoPtr__ctor_Public_Void_Boolean_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060109F9 RID: 68089 RVA: 0x003D99D8 File Offset: 0x003D7BD8
			[CallerCount(1)]
			[CachedScanResults(RefRangeStart = 273618, RefRangeEnd = 273619, XrefRangeStart = 273606, XrefRangeEnd = 273618, MetadataInitTokenRva = 0L, MetadataInitFlagRva = 0L)]
			public unsafe void Release(NoteHeadFinishAnimationController instance)
			{
				IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
				IntPtr* ptr = stackalloc IntPtr[checked(unchecked((UIntPtr)1) * (UIntPtr)sizeof(IntPtr))];
				*ptr = IL2CPP.Il2CppObjectBaseToPtr(instance);
				IntPtr intPtr2;
				IntPtr intPtr = IL2CPP.il2cpp_runtime_invoke(NoteHeadFinishAnimationController.RemoveContext.NativeMethodInfoPtr_Release_Public_Void_NoteHeadFinishAnimationController_0, IL2CPP.il2cpp_object_unbox(IL2CPP.Il2CppObjectBaseToPtrNotNull(this)), (void**)ptr, ref intPtr2);
				Il2CppException.RaiseExceptionIfNecessary(intPtr2);
			}

			// Token: 0x060109FA RID: 68090 RVA: 0x00091028 File Offset: 0x0008F228
			public RemoveContext(IntPtr pointer) : base(pointer)
			{
			}

			// Token: 0x060109FB RID: 68091 RVA: 0x00091031 File Offset: 0x0008F231
			public RemoveContext() : base(IL2CPP.il2cpp_object_new(Il2CppClassPointerStore<NoteHeadFinishAnimationController.RemoveContext>.NativeClassPtr))
			{
			}

			// Token: 0x170056AF RID: 22191
			// (get) Token: 0x060109FC RID: 68092 RVA: 0x003D9A20 File Offset: 0x003D7C20
			// (set) Token: 0x060109FD RID: 68093 RVA: 0x00091043 File Offset: 0x0008F243
			public unsafe HashSet<NoteHeadFinishAnimationController> _active
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadFinishAnimationController.RemoveContext.NativeFieldInfoPtr__active);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<HashSet<NoteHeadFinishAnimationController>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadFinishAnimationController.RemoveContext.NativeFieldInfoPtr__active), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056B0 RID: 22192
			// (get) Token: 0x060109FE RID: 68094 RVA: 0x003D9A50 File Offset: 0x003D7C50
			// (set) Token: 0x060109FF RID: 68095 RVA: 0x00091062 File Offset: 0x0008F262
			public unsafe ObjectPool<NoteHeadFinishAnimationController> _pool
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadFinishAnimationController.RemoveContext.NativeFieldInfoPtr__pool);
					IntPtr intPtr2 = *intPtr;
					return (intPtr2 != 0) ? Il2CppObjectPool.Get<ObjectPool<NoteHeadFinishAnimationController>>(intPtr2) : null;
				}
				set
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this);
					IL2CPP.il2cpp_gc_wbarrier_set_field(intPtr, intPtr + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadFinishAnimationController.RemoveContext.NativeFieldInfoPtr__pool), IL2CPP.Il2CppObjectBaseToPtr(value));
				}
			}

			// Token: 0x170056B1 RID: 22193
			// (get) Token: 0x06010A00 RID: 68096 RVA: 0x003D9A80 File Offset: 0x003D7C80
			// (set) Token: 0x06010A01 RID: 68097 RVA: 0x00091081 File Offset: 0x0008F281
			public unsafe bool _destroyInstance
			{
				get
				{
					IntPtr intPtr = IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadFinishAnimationController.RemoveContext.NativeFieldInfoPtr__destroyInstance);
					return *intPtr;
				}
				set
				{
					*(IL2CPP.Il2CppObjectBaseToPtrNotNull(this) + (IntPtr)IL2CPP.il2cpp_field_get_offset(NoteHeadFinishAnimationController.RemoveContext.NativeFieldInfoPtr__destroyInstance)) = value;
				}
			}

			// Token: 0x0400A838 RID: 43064
			private static readonly IntPtr NativeFieldInfoPtr__active;

			// Token: 0x0400A839 RID: 43065
			private static readonly IntPtr NativeFieldInfoPtr__pool;

			// Token: 0x0400A83A RID: 43066
			private static readonly IntPtr NativeFieldInfoPtr__destroyInstance;

			// Token: 0x0400A83B RID: 43067
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_HashSet_1_NoteHeadFinishAnimationController_ObjectPool_1_NoteHeadFinishAnimationController_0;

			// Token: 0x0400A83C RID: 43068
			private static readonly IntPtr NativeMethodInfoPtr__ctor_Public_Void_Boolean_0;

			// Token: 0x0400A83D RID: 43069
			private static readonly IntPtr NativeMethodInfoPtr_Release_Public_Void_NoteHeadFinishAnimationController_0;
		}
	}
}
